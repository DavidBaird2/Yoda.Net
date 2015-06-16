
namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ApplyConflictedUserData : IPacket
    {
        public string userCode;
        public ApplyConflictedUserData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.APPLY_CONFLICTED_PIGG;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(userCode);

        }
    }
}

