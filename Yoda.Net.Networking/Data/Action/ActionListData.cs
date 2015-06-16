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
        public ArrayList _list;
        public ActionListData(ArrayList param1)
        {
            _list = param1;
            return;
        }
        public AmebaStream binary()
        {
            var _loc_4 = new AmebaStream();
            foreach (ActionData _loc_6 in _list)
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
            var _loc_4 = new AmebaStream(zlib.uncompress(data.toArrayLast()));
            _list = new ArrayList();
            int _loc_5 = 0;
            while (_loc_5 < actionCount)
            {

                var _loc_6 = new ActionData();
                _loc_6.code = _loc_4.readUTF();
                _list.Add(_loc_6);
                _loc_5++;
            }
        }
        public int length()
        {
            return _list.Count;
        }
    }
}
