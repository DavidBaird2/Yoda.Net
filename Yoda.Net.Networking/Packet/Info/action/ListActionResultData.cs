using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Yoda.Net.Networking.Packet.Info;

using Yoda.Net.Common;
using Yoda.Net.Networking.Data.Action;

namespace Yoda.Net.Networking.Packet.Info.action
{
    public class ListActionResultData : IPacket
    {
          public ArrayList list;

        public ListActionResultData()
        {
            return;
        }

        public void readData(AmebaStream In)
        {
            ActionData _loc_6 = null;
            var actionCount = In.readInt();
            var CompressedByte = In.readInt();
            FileCompressionUtility zlib = new FileCompressionUtility();
            var _loc_4 = new AmebaStream(zlib.uncompress(In.toArrayLast()));
            list = new ArrayList(actionCount);
            int _loc_5= 0;
            while (_loc_5 < actionCount)
            {
                
                _loc_6 = new ActionData();
                _loc_6.readData(_loc_4);
                list.Add(_loc_6);
                _loc_5++;
            }
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(list.Count);

            var _loc_4 = new AmebaStream();

            foreach (ActionData _loc_6 in list)
            {


                _loc_6.writeData(_loc_4);

            }
            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] compressed = zlib.Compress(_loc_4.toArray());
            Out.writeInt(compressed.Length);
            Out.writeBytes(compressed);
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_ACTION_RESULT;
            }
        }

    }
}
