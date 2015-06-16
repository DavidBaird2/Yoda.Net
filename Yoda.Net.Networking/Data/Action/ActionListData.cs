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
        public ActionListData(ArrayList param1)
        {
            list = param1;
            return;
        }
        public AmebaStream binary()
        {
            var _loc_4 = new AmebaStream();
            foreach (ActionData _loc_6 in list)
            {
                _loc_4.writeUTF(_loc_6.code);

            }
            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] compressed = zlib.Compress(_loc_4.toArray());
            _loc_4.position = 0;
            return _loc_4;
        }
        public void decompress(AmebaStream data, int actionCount)
        {
            FileCompressionUtility zlib = new FileCompressionUtility();
            var stream = new AmebaStream(zlib.uncompress(data.toArrayLast()));
            list = new ArrayList();
            int num = 0;
            while (num < actionCount)
            {

                var _loc_6 = new ActionData();
                _loc_6.code = stream.readUTF();
                list.Add(_loc_6);
                num++;
            }
        }
        public int length()
        {
            return list.Count;
        }
    }
}
