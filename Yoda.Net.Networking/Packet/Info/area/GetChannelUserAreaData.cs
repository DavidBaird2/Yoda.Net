using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    class GetChannelUserAreaData : IPacket
    {

        public string _userCode;
        public GetChannelUserAreaData(string code)
        {
            this._userCode = code;
        }
        public int packetId
        {
            get
            {
                return PacketId.VJ_CHANNEL_USER_AREA;
            }
        }

        public void readData(AmebaStream In)
        {

            _userCode = In.readUTF();

            return;

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_userCode);

            return;
        }
    }
}
