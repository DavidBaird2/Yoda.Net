using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class ChangeRoomWindowData :IPacket
	{
        public AmebaStream byteArray;
        public string method;
        public ChangeRoomWindowData(string _method, AmebaStream _byteArray)
        {
            this.method = _method;
            this.byteArray = _byteArray;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.CHANGE_WINDOW_AQUARIUM;
            }
        }

        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(method);
            Out.writeBytes(this.byteArray, (int)this.byteArray.position, (int)(this.byteArray.length - this.byteArray.position));
            return;
        }

	}
}
