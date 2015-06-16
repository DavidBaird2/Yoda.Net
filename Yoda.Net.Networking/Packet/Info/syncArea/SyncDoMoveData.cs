using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.syncArea
{
    public class SyncDoMoveData : IPacket, IEncrypted
    {

        private string _areaCategory;
        private int _x;
        private int _y;
        private int _z;
        public int packetId
        {
            get
            {
                return PacketId.SYNC_DO_MOVE_AREA_INTERNAL;
            }
        }

        public SyncDoMoveData(string param1, int param2, int param3, int param4)
        {
            _areaCategory = param1;
            _x = param2;
            _y = param3;
            _z = param4;
            return;
        }
        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_areaCategory);
            Out.writeUTF(_areaCategory);
            Out.writeInt(_x);
            Out.writeInt(_y);
            Out.writeInt(_z);
            return;
        }
    }
}
