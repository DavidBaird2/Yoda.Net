
namespace Yoda.Net.Networking.Packet.Info.recycledarts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    

    public class RecycleDartsGetData : ICommandData
    {
        public RecycleDartsGetData()
        {
        }
        public string gachaCode;

        public int packetId
        {
            get
            {
                return PacketId.RECYCLE_DARATS_DATA;
            }
        }
        public RecycleDartsGetData(string gachaCode)
        {
            this.gachaCode = gachaCode;
            return;
        } 
        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(gachaCode);
        }
    }
}

