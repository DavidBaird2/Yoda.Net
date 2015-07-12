namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;

    using System;

    public class ListGoodData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_GOOD;
            }
        }
        public ListGoodData()
        {
            return;
        }
        public void readData(PiggStream In)
        {
            return;
        }

        public void writeData(PiggStream Out)
        {

            return;
        }
    }
}

