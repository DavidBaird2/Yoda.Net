using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Chat.channel
{
    public class UpdateFanRequest : IPacket
    {
        public UpdateFanRequest()
        {

        }

        public void readData(AmebaStream In)
        {


            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._targetUsercode);
        }

        public int packetId
        {
            get
            {
                return PacketId.CHANNEL_FLOOR_UPDATE_FAN_REQUEST;
            }
        }


        public string _targetUsercode { get; set; }
    }
}
