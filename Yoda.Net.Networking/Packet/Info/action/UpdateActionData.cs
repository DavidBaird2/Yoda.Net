using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Yoda.Net.Networking.Packet.Info;


using Yoda.Net.Networking.Packet.Data.action;

namespace Yoda.Net.Networking.Packet.Info.action
{
    class UpdateActionData : IPacket
    {
        public ActionListData _listData;

          public UpdateActionData()
        {
            return;
        }

        public void readData(AmebaStream In)
        {
            _listData = new ActionListData(new ArrayList());
            int count = In.readInt();
            _listData.decompress(In, count);
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(_listData.length());
            Out.writeBytes(_listData.binary().toArray());
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.UPDATE_ACTION;
            }
        }

    }
}
