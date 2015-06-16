namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ConflictedPiggData : IPacket
    {

        public ConflictedPiggData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.GET_CONFLICTED_PIGG;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
 

        }
    }
}

