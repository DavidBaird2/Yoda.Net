namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;
    using Yoda.Net.Networking.Packet.Chat;


    public class SendTypingResultData : ICommandData
    {
        public string code;


        public SendTypingResultData(string code)
        {
            this.code = code;

        }
        public SendTypingResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.TYPING_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTFBytes(16);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(this.code);

        }
    }
}

