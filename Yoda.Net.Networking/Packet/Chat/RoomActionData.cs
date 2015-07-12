namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class RoomActionData : ICommandData, IEncrypted
    {
        public string actionCode;
        public PiggStream data;
        public bool isAdminRequest;

        public RoomActionData()
        {
        }

        public RoomActionData(string actionCode = "", PiggStream data = null)
        {
            this.actionCode = actionCode;
            this.data = data;
        }

        public int packetId
        {
            get
            {
                return PacketId.ROOM_ACTION;
            }
        }

        public void readData(PiggStream In)
        {
         actionCode=   In.readUTF();
            
        }

        public void writeData(PiggStream Out)
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

