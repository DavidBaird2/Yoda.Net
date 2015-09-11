namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;


    public class CancelTypingData : ICommandData
    {
        public string code;
    

        public CancelTypingData(string code)
        {
            this.code = code;

        }
        public CancelTypingData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.CANCEL_TYPING;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
        }
    }
}

