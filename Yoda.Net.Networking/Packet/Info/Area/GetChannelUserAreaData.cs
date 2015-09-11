using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class GetChannelUserAreaData : ICommandData
    {
        public GetChannelUserAreaData()
        {
        }
        public string userCode;
        public GetChannelUserAreaData(string code)
        {
            this.userCode = code;
        }
        public int packetId
        {
            get
            {
                return PacketId.VJ_CHANNEL_USER_AREA;
            }
        }

        public void readData(PiggStream In)
        {

            userCode = In.readUTF();

            return;

        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);

            return;
        }
    }
}
