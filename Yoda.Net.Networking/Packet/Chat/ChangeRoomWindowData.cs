using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
    public class ChangeRoomWindowData : ICommandData
    {
        public PiggStream byteArray;
        public string method;
        public ChangeRoomWindowData(string _method, PiggStream _byteArray)
        {
            this.method = _method;
            this.byteArray = _byteArray;
            return;
        }
        public ChangeRoomWindowData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.CHANGE_WINDOW_AQUARIUM;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(method);
            Out.writeBytes(this.byteArray, (int)this.byteArray.position, (int)(this.byteArray.length - this.byteArray.position));
            return;
        }

    }
}
