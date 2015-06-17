using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Common;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Packet.Info.create
{
    public class CreateAvatarData
    {
        private string _room = "orange";
        private BodyColorData _color;
        private BodyPositionData _position;
        private BodyPartData _part;
        private BodyItemData _item;
        public CreateAvatarData(BodyPartData param1, BodyColorData param2, BodyPositionData param3, BodyItemData param4, string param5)
        {
            _part = param1;
            _color = param2;
            _position = param3;
            _item = param4;
            _room = param5;
            return;
        }
        public CreateAvatarData()
        {
            _color = new BodyColorData();
            _position = new BodyPositionData();
            _part = new BodyPartData();
            _item = new BodyItemData();
        }
        public byte[] binary()
        {
            var _loc_1 = new AmebaStream();

         //   _part.gender = 0;
            _part.writeData(_loc_1, true);
            _color.writeData(_loc_1);
            _position.writeData(_loc_1);
        //    _item.items[0] = "skirt_standard_pink";
            _item.writeData(_loc_1);

            _loc_1.writeUTF(_room);

            _loc_1.position = 0;
            byte[] data = _loc_1.readBytes((int)_loc_1.length);
            FileCompressionUtility util = new FileCompressionUtility();
            byte[] Compresseddata = util.Compress(data);
            return Compresseddata;
        }
        public void Decompress(byte[] cdata)
        {

            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] _data = zlib.uncompress(cdata);

            var _loc_1 = new AmebaStream(_data);
            _part.readData(_loc_1, true);
            _color.readData(_loc_1);
            _position.readData(_loc_1);
            _item.readData(_loc_1);
            _room = _loc_1.readUTF();

        }

    }
}
