namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ApplyConflictedUserData : ICommandData
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

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);

        }
    }
}

