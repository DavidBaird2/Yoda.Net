using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    class GetUserAreaResultData:ICommandData
    {
        public int enterableZone;
        public string code;
        public int userZone;
        public string category;

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_AREA_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            category = In.readUTF();
            code = In.readUTF();
            userZone = In.readByte();
            enterableZone = In.readByte();
            return;

        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
            Out.writeByte((byte)userZone);
            Out.writeByte((byte)enterableZone);
            return;
        }
    }
}
