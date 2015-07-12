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
    public class ListActionResultData : ICommandData
    {
          public ArrayList list;

        public ListActionResultData()
        {
            return;
        }

        public void readData(PiggStream In)
        {
            ActionData data = null;
            var actionCount = In.readInt();
            var CompressedByte = In.readInt();
            FileCompressionUtility zlib = new FileCompressionUtility();
            var stream = new PiggStream(zlib.uncompress(In.toArrayLast()));
            list = new ArrayList(actionCount);
            int n= 0;
            while (n < actionCount)
            {
                
                data = new ActionData();
                data.readData(stream);
                list.Add(data);
                n++;
            }
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(list.Count);

            var stream = new PiggStream();

            foreach (ActionData data in list)
            {


                data.writeData(stream);

            }
            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] compressed = zlib.Compress(stream.toArray());
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
