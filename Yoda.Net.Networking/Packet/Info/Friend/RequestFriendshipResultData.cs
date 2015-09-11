namespace Yoda.Net.Networking.Packet.Info.Friend
{


    using System;
    using System.Collections;


    public class RequestFriendshipResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.REQUEST_FRIENDSHIP_RESULT;
            }
        }

        private static int SUCCESS = 0;
        private static int FAILURE = 1;
        private static int TYPE_TOO_MANY_PENDING_REQUESTS = 16;
        private static int TYPE_TOO_MANY_WAITING_REQUESTS = 32;
        private static int TYPE_NOT_ALLOWED_FAILURE = 48;
        private static int TYPE_TOO_MANY_FRIEND_REQUESTS = 64;
        public void readData(PiggStream In)
        {
            this.hexCode = In.readUTF();
            this.type = In.readByte();

            if (In.readBoolean()) this.numMax = In.readInt();
        }


        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(hexCode);
            Out.writeByte(type);
            if (numMax != 0)
            {
                Out.writeBoolean(true);
                Out.writeInt(numMax);
            }
        }


        public string hexCode { get; set; }

        public sbyte type { get; set; }

        public int numMax { get; set; }
    }
}

