namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using System;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Chat;

    public class StartDressupData : ICommandData, IEncrypted
    {


        public StartDressupData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.START_DRESSUP;
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

