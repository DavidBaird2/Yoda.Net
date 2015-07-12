namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterQueueStartResultData :  ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.ENTER_QUEUE_START_RESULT;
            }
        }
        public EnterQueueStartResultData()
        {
            return;
        }



        public void readData(PiggStream stream)
        {
            this.category = stream.readUTF();
            this.subCategoryCode = stream.readUTF();
            this.areaCode = stream.readUTF();
            this.roomIndex = stream.readInt();
            this.areaType = stream.readByte();
            this.imagePath = stream.readUTF();
            this.upperDescription = stream.readUTF();
            this.lowerDescription = stream.readUTF();
            this.count = stream.readInt();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
           
        }


        public string category { get; set; }

        public string subCategoryCode { get; set; }

        public string areaCode { get; set; }

        public sbyte areaType { get; set; }

        public int count { get; set; }

        public string lowerDescription { get; set; }

        public string upperDescription { get; set; }

        public string imagePath { get; set; }

        public int roomIndex { get; set; }
    }
}

