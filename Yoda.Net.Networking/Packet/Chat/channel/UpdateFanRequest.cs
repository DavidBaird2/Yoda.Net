using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Chat.Channel
{
    public class UpdateFanRequest : ICommandData, IEncrypted, IncludeClientTime
    {
        public UpdateFanRequest()
        {

        }

        public void readData(PiggStream In)
        {
            targetUsercode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.targetUsercode);
        }

        public int packetId
        {
            get
            {
                return PacketId.CHANNEL_FLOOR_UPDATE_FAN_REQUEST;
            }
        }


        public string targetUsercode { get; set; }
    }
}
