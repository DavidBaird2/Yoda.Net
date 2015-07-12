namespace Yoda.Net.Networking.Data.Create
{
    using System;
    using System.Collections;
    using Yoda.Net.Common;
    using Yoda.Net.Networking.Data.Common;
    
    

    public class CreateAvatarData
    {
        private string _room = "orange";
        private BodyColorData _color;
        private BodyPositionData _position;
        private BodyPartData _part;
        private BodyItemData _item;
        public CreateAvatarData(BodyPartData part, BodyColorData color, BodyPositionData position, BodyItemData item, string room)
        {
            _part = part;
            _color = color;
            _position = position;
            _item = item;
            _room = room;
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
            var stream = new PiggStream();

            _part.writeData(stream,true);
            _color.writeData(stream);
            _position.writeData(stream);
            _item.items[0] = "skirt_standard_pink";
            _item.writeData(stream);
          
            stream.writeUTF(_room);

            stream.position = 0;
            byte[] data = stream.readBytes((int)stream.length);
            FileCompressionUtility util = new FileCompressionUtility();
            byte[] Compresseddata = util.Compress(data);
            return Compresseddata;
        }
        public void Decompress(byte[] cdata)
        {
 
            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] _data = zlib.uncompress(cdata);

            var stream = new PiggStream(_data);
            _part.readData(stream,true);
            _color.readData(stream);
            _position.readData(stream);
            _item.readData(stream);
            _room = stream.readUTF();

        }

    }
}

