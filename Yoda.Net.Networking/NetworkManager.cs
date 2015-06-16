using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Yoda.Net.Common;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Networking
{
    public delegate void SocketCloseedEventHandler();
    public delegate void PacketEventHandler(Header header, AmebaStream body, AmebaStream rawPacket);
    public class NetworkManager
    {
        public event PacketEventHandler OnRecvPacket;
        public event SocketCloseedEventHandler OnSocketClosed;
        private Header header;
        private AmebaStream clientMessage;
        private object streamLock = new object();
        public Socket socket;
        private IMessageDelegate _delegate;
        private byte[] mServerBuffer;

        public const short TYPE_COMMAND = 0x10;
        public const short TYPE_ENC = 0x1f1;
        public const short TYPE_ID = 0x1f0;
        public const short TYPE_PING = 0x1ff;
        public int encId;
        public int connectionId;
        private int mServerBufferSize = 0;
        public NetworkManager(IMessageDelegate del)
        {
            this.mServerBuffer = new byte[65535];
            clientMessage = new AmebaStream();
            this._delegate = del;
        }
        public void Dissconect()
        {
            this.socket.Close();
        }

        public bool Connected
        {
            get { return socket.Connected; }
        }
        private void readBuffer()
        {
            while (true)
            {

                if (this.header == null)
                {
                    clientMessage.position = 0;
                    if (clientMessage.length < 12)
                    {
                        break;//not complite recived header
                    }
                    clientMessage.position = 0;
                    this.header = new Header();
                    this.header.read(clientMessage);
                }
                if (this.clientMessage.length < this.header.length + 12)
                {
                    //not complete recived body
                    break; //not complete recived body
                }
                this.clientMessage.position = 12;
                var rawPacket = new AmebaStream();
                header.write(rawPacket);
                AmebaStream Body = new AmebaStream(clientMessage.readBytes(header.length));
                rawPacket.writeBytes(Body.toArray());
                rawPacket.position = 0;
                try
                {
                    OnRecvPacket(header, Body, rawPacket);
                }
                catch(Exception ex)
                {
                    Logger.Log(Common.LogLevel.Attention, ex.ToString());
                }


                clientMessage = new AmebaStream(clientMessage.toArrayLast());
                this.header = null;

            }


        }

        public byte[] getEncryptionKey()
        {
            AmebaStream stream = new AmebaStream();
            stream.writeInt(encId);
            stream.writeInt(connectionId);
            stream.position = 0;
            return stream.toArray();
        }

        public void SetSocket(Socket socket)
        {
            this.socket = socket;
            WaitData();
        }

        public void Connect(string host, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socket.Connect(host, port);
            WaitData();
        }
        public void StopClient()
        {
            this.socket.Shutdown(SocketShutdown.Both);
            socket.BeginDisconnect(true, new AsyncCallback(DisconnectCallback), this.socket);
        }

        private void DisconnectCallback(IAsyncResult ar)
        {

            // Retrieve the socket from the state object.
            Socket client = (Socket)ar.AsyncState;

            // Complete the disconnection.
            client.EndDisconnect(ar);

            this.socket.Close();

            OnSocketClosed();

        }



        private void WaitData()
        {
            this.socket.BeginReceive(this.mServerBuffer, 0, this.mServerBuffer.Length, 0, new AsyncCallback(this.ReceivedDataAsync), null);
        }
        protected void ReceivedDataAsync(IAsyncResult iAr)
        {
            if (!Connected)
                return;
            try
            {
                this.mServerBufferSize = this.socket.EndReceive(iAr);
            }
            catch (SocketException) { }
            byte[] Received = new byte[mServerBufferSize];
            Buffer.BlockCopy(mServerBuffer, 0, Received, 0, mServerBufferSize);
            string Data = System.Text.Encoding.UTF8.GetString(Received);
            if (Received.Length <= 0)
            {
                StopClient();
                return;　//Dissconected by Client
            }
            lock (streamLock)
            {
                clientMessage.position = clientMessage.length;
                clientMessage.writeBytes(Received);
                readBuffer();
            }

            WaitData();

        }


        private void SendCallback(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            client.EndSend(ar);
        }


        public void SendData(byte[] byteData)
        {
            socket.BeginSend(byteData, 0, byteData.Length, 0,
     new AsyncCallback(SendCallback), socket);
        }
        public void SendCommand(IPacket data)
        {
            AmebaStream @out = new AmebaStream();
            @out.writeShort(TYPE_COMMAND);
            @out.writeShort((short)data.packetId);
            @out.position = 11L;
            @out.writeByte(0);

            var stream = new AmebaStream();
            data.writeData(stream);
            if (data is IncludeClientTime)
                stream.writeDate(DateTime.Now);

            if (data is IEncrypted)
                Des.encrypt(out stream, stream, getEncryptionKey());

            @out.writeBytes(stream.toArray());
            @out.position = 4L;
            @out.writeInt(((int)@out.BaseStream.Length) - 12);
            @out.writeInt(0);
            @out.position = 0L;
            byte[] bData = @out.readBytes((int)@out.BaseStream.Length);
            this.SendData(bData);

        }

    }
}
