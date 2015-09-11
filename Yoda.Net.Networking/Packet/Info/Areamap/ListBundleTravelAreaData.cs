
namespace Yoda.Net.Networking.Packet.Info.Areamap
{
    
    
    using System;


    public class ListBundleTravelAreaData  : ICommandData
    {


        public string categoryCode { get; set; }
        
        public sbyte requestModule { get; set; }

        public string code { get; set; }


        public ListBundleTravelAreaData()
        {

        }


        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_BUNDLE;
            }
        }

        public void readData(PiggStream In)
        {
            categoryCode = In.readUTF();
            code = In.readUTF();
            requestModule = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
         
            Out.writeUTF(this.categoryCode);
            Out.writeUTF(this.code);
            Out.writeByte(this.requestModule);
          
        }



    }
}

