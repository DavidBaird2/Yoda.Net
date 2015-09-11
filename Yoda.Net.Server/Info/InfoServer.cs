using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Server.Info;

namespace Yoda.Net.Server.Info
{
    public class InfoServer
    {
        public List<RemortClient> Clients;
        public TcpListener Listener { get; set; }
        public IMessageHandler handler;
        public InfoServer()
        {
            clientCounter = 100000;
            Clients = new List<RemortClient>();
            SetHandler(new InfoMessageHandler(this));
        }
        public void SetHandler(IMessageHandler handler)
        {
            this.handler = handler;
        }
        public void Start(IPEndPoint ipEndPoint)
        {
            Listener = new TcpListener(ipEndPoint);
            Listener.Start();
            Listener.BeginAcceptTcpClient(AcceptClientAsync, null);
        }
        public void BroadCastMessage(ICommandData data)
        {
            Clients.ForEach(i => i.manager.SendCommand(data));
        }
        public void KillClient(int clientId)
        {
            var client = GetClient(clientId);
            client.Stop();

        }
        public RemortClient GetClient(int clientId)
        {
          return  Clients.Where(i => i.ConnectionId == clientId).SingleOrDefault();
        }
        public RemortClient GetClinet(byte[] secure)
        {
            return Clients.Where(i => i.secure.SequenceEqual(secure)).SingleOrDefault();
        }
        public void AcceptClientAsync(IAsyncResult ar)
        {
            clientCounter++;
            var socket = Listener.EndAcceptTcpClient(ar).Client;
            var manager = new SocketManager(handler);
            manager.connectionId = clientCounter;
            manager.SetSocket(socket);
           
            RemortClient client = new RemortClient(this, manager);
            Listener.BeginAcceptTcpClient(AcceptClientAsync, null);
        }
        public void RemoveClient(RemortClient client)
        {
            Clients.Remove(client);
        }
        public void AddClient(RemortClient client)
        {
            Clients.Add(client);
        }

        public int clientCounter { get; set; }
    }
}
