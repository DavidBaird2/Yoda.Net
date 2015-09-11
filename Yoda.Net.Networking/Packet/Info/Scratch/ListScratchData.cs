namespace Yoda.Net.Networking.Packet.Info.Item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class ListScratchData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_SCRATCH;
            }
        }
        public ListScratchData()
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

