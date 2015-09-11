namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class SearchEventData : ICommandData
    {
        public SearchEventData()
        {
        }
       
        public int packetId
        {
            get
            {
                return PacketId.SEARCH_NOTICE_BOARD_MESSAGE;
            }
        }
    
        public void readData(PiggStream In)
        {
            category = In.readUTF();
            searchQuery = In.readUTF();
            orderBy = In.readByte();
            option = In.readByte();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.category);
            Out.writeUTF(this.searchQuery);
            Out.writeByte(this.orderBy);
            Out.writeByte(this.option);
            return;
        }

        public string category { get; set; }

        public string searchQuery { get; set; }

        public sbyte option { get; set; }

        public sbyte orderBy { get; set; }
    }
}

