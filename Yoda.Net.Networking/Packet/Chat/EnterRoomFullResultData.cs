namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomFullResultData :  ICommandData
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



        public void readData(PiggStream stream)
        {
            this.category = stream.readUTF();
            this.subCategoryCode = stream.readUTF();
            this.areaCode = stream.readUTF();
            this.roomIndex = stream.readInt();
            if (!(this.canQueue = stream.readBoolean()))
            {
                this.errorMessage = stream.readUTF();
                return;
            }

            this.areaType = stream.readByte();
            this.thumbnailPath = stream.readUTF();
            this.upperDescription = stream.readUTF();
            this.lowerDescription = stream.readUTF();
            this.count = stream.readInt();
            this.lastQueueableSize = stream.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
    
        }




        public string subCategoryCode { get; set; }
    }
}

