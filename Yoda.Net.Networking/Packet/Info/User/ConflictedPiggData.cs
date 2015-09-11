namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ConflictedPiggData : ICommandData
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

        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {
 

        }
    }
}

