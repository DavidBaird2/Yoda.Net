namespace Yoda.Net.Networking.Packet.Info.Channel
{
    using System;
    using System.Collections;
    public class BoothCatalogResult : ICommandData
    {

        public int packetId
        {
            get
            {
                return Yoda.Net.Networking.Packet.Chat.PacketId.CHANNEL_PARTY_GET_BOOTHCATALOG_RESULT;
            }
        }
        public void writeData(PiggStream Out)
        {
            
        }

        public void readData(PiggStream In)
        {
       
        }

    }
}
