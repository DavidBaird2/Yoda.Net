namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;


    public class MoveRoomData : IPacket,IEncrypted
    {
 public int room;
        public bool targetUser;



        public int packetId
        {
            get
            {
                return PacketId.MOVE_USER_ROOM;
            }
        }

        public void readData(AmebaStream In)
        {
            room = In.readInt();
            targetUser = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this.room);
            Out.writeBoolean(this.targetUser);
        }
    }
}

