using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.syncArea
{
    public class SyncDoTalkData : ICommandData, IEncrypted
    {
        public SyncDoTalkData()
        {
        }
        public int color;
        public string message;
        public string areaCategory;
        public int packetId
        {
            get
            {
                return PacketId.SYNC_DO_TALK_AREA_INTERNAL;
            }
        }

        public SyncDoTalkData(string areaCategory, string message, int color)
        {
            this.areaCategory = areaCategory;

            this.message = message;

            this.color = color;
            return;
        }
        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(areaCategory);
            Out.writeUTF(areaCategory);
            Out.writeUTF(message);
            Out.writeInt(color);
            Out.writeUTF(areaCategory);
        }
    }
}
