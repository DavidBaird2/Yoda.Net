using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.syncArea
{
    public class SyncDoTalkData : IPacket, IEncrypted
    {

        private int _color;
        private string _message;
        private string _areaCategory;
        public int packetId
        {
            get
            {
                return PacketId.SYNC_DO_TALK_AREA_INTERNAL;
            }
        }

        public SyncDoTalkData(string param1, string param2, int param3)
        {
            _areaCategory = param1;
            _message = param2;
            _color = param3;
            return;
        }
        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_areaCategory);
            Out.writeUTF(_areaCategory);
            Out.writeUTF(_message);
            Out.writeInt(_color);
            Out.writeUTF(_areaCategory);
        }
    }
}
