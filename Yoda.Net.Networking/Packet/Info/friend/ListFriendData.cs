namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    
    using System;
    using System.Collections;


    public class NotifyFriendStatusData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_FRIEND_STATUS;
            }
        }

        public void readData(AmebaStream In)
        {

            this.userCode = In.readUTF();
            this.status = In.readByte();
            this.name = In.readUTF();
        }


        public void writeData(AmebaStream Out)
        {


        }

        public string userCode { get; set; }

        public sbyte status { get; set; }

        public string name { get; set; }
        public static readonly int STATUS_ONLINE = 1;

        public static readonly int STATUS_OFFLINE = 2;

    }
}

