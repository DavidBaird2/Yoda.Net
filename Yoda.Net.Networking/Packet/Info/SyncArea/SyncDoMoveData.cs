using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.SyncArea
{
    public class SyncDoMoveData : ICommandData, IEncrypted
    {
        public SyncDoMoveData()
        {
        }
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

        public SyncDoMoveData(string areaCategory, int x, int y, int z)
        {
            _areaCategory = areaCategory;
            _x = x;
            _y = y;
            _z = z;
            return;
        }
        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
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
