namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;


    public class CancelTypingResultData : ICommandData
    {
        public string code;


        public CancelTypingResultData(string code)
        {
            this.code = code;

        }
        public CancelTypingResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.CANCEL_TYPING_RESULT;
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

