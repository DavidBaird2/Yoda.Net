namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;
    using Yoda.Net.Networking.Packet.Chat;


    public class SendTypingData : ICommandData
    {
        public string code;


        public SendTypingData(string code)
        {
            this.code = code;

        }
        public SendTypingData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.TYPING;
            }
        }

        public void readData(PiggStream In)
        {
           
        }

        public void writeData(PiggStream Out)
        {
            
        }


    }
}

