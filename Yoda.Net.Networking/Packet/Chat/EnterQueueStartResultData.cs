namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterQueueStartResultData :  IPacket,IEncrypted
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



        public void readData(AmebaStream param1)
        {
            this.category = param1.readUTF();
            this.subCategoryCode = param1.readUTF();
            this.areaCode = param1.readUTF();
            this.roomIndex = param1.readInt();
            this.areaType = param1.readByte();
            this.imagePath = param1.readUTF();
            this.upperDescription = param1.readUTF();
            this.lowerDescription = param1.readUTF();
            this.count = param1.readInt();
        }

        public void writeData(AmebaStream Out)
        {

            return;
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

