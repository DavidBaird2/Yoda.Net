
namespace Yoda.Net.Networking.Packet.Info.recycledarts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    

    public class RecycleDartsGetData : IPacket
    {
        public string _gachaCode;

        public int packetId
        {
            get
            {
                return PacketId.RECYCLE_DARATS_DATA;
            }
        }
        public RecycleDartsGetData(string gachaCode)
        {
            this._gachaCode = gachaCode;
            return;
        } 
        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_gachaCode);
        }
    }
}

