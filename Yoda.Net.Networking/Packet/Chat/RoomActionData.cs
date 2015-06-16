namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class RoomActionData : IPacket, IEncrypted
    {
        public string actionCode;
        public AmebaStream data;
        public bool isAdminRequest;

        public RoomActionData()
        {
        }

        public RoomActionData(string param1 = "", AmebaStream param2 = null)
        {
            this.actionCode = param1;
            this.data = param2;
        }

        public int packetId
        {
            get
            {
                return PacketId.ROOM_ACTION;
            }
        }

        public void readData(AmebaStream In)
        {
         actionCode=   In.readUTF();
            
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.actionCode);
            if (this.data == null)
            {
                Out.writeShort(-1);
            }
            else
            {
                if (this.data.length > 0x400L)
                {
                }
                this.data.position = 0L;
                Out.writeShort((short)this.data.length);
            }
            Out.writeBoolean(false);
        }
    }
}

