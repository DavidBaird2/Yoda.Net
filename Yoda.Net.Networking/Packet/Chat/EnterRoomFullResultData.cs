namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomFullResultData :  IPacket,IEncrypted
    {
        public String category;
        public String areaCode;
        public int roomIndex;
        public String title;
        public int max;
        public Boolean isUserRoom;
        public string errorMessage { get; set; }
        public sbyte areaType { get; set; }
        public string thumbnailPath { get; set; }
        public string upperDescription { get; set; }
        public string lowerDescription { get; set; }
        public int count { get; set; }
        public int lastQueueableSize { get; set; }
        public bool canQueue { get; set; }
        public int packetId
        {
            get
            {
                return PacketId.ENTER_ROOM_FULL_RESULT;
            }
        }
        public EnterRoomFullResultData()
        {
            return;
        }



        public void readData(AmebaStream param1)
        {
            this.category = param1.readUTF();
            this.subCategoryCode = param1.readUTF();
            this.areaCode = param1.readUTF();
            this.roomIndex = param1.readInt();
            if (!(this.canQueue = param1.readBoolean()))
            {
                this.errorMessage = param1.readUTF();
                return;
            }

            this.areaType = param1.readByte();
            this.thumbnailPath = param1.readUTF();
            this.upperDescription = param1.readUTF();
            this.lowerDescription = param1.readUTF();
            this.count = param1.readInt();
            this.lastQueueableSize = param1.readInt();
            return;
        }

        public void writeData(AmebaStream Out)
        {
           /* Out.writeUTF(category);
            Out.writeUTF(code);
            Out.writeUTF(title);
            Out.writeInt(max);*/
            return;
        }




        public string subCategoryCode { get; set; }
    }
}

