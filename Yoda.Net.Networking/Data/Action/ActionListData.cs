using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Common;



namespace Yoda.Net.Networking.Data.Action
{
    class ActionListData
    {
        public ArrayList list;
        public ActionListData(ArrayList  list)
        {
            this.list = list;
            return;
        }
        public PiggStream binary()
        {
            var stream = new PiggStream();
            foreach (ActionData ad in list)
            {
                stream.writeUTF(ad.code);

            }
            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] compressed = zlib.Compress(stream.toArray());
            stream.position = 0;
            return stream;
        }
        public void decompress(PiggStream data, int actionCount)
        {
            FileCompressionUtility zlib = new FileCompressionUtility();
            var stream = new PiggStream(zlib.uncompress(data.toArrayLast()));
            list = new ArrayList();
            int num = 0;
            while (num < actionCount)
            {

                var ad = new ActionData();
                ad.code = stream.readUTF();
                list.Add(ad);
                num++;
            }
        }
        public int length()
        {
            return list.Count;
        }
    }
}
