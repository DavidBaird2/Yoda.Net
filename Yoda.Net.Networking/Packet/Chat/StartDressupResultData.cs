namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using System;
    using Yoda.Net.Networking.Packet;
    public class StartDressupResultData : ICommandData
    {

        public string hexCode;
        public StartDressupResultData()
        {
        }
        public StartDressupResultData(string hexCode)
        {
            this.hexCode = hexCode;
        }
        public int packetId
        {
            get
            {
                return PacketId.START_DRESSUP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            hexCode = In.readUTFBytes(16);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(hexCode);
        }
    }
}

