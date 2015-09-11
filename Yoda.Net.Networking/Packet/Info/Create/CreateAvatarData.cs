using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Common;
using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Packet.Info.Create
{
    public class CreateAvatarData
    {
        public string room = "orange";
        public BodyColorData color;
        public BodyPositionData position;
        public BodyPartData part;
        public BodyItemData item;
        public CreateAvatarData(BodyPartData part, BodyColorData color, BodyPositionData position, BodyItemData item, string room)
        {
            this.part = part;
            this.color = color;
            this.position = position;
            this.item = item;
            this.room = room;
            return;
        }
        public CreateAvatarData()
        {
            color = new BodyColorData();
            position = new BodyPositionData();
            part = new BodyPartData();
            item = new BodyItemData();
        }
        public byte[] binary()
        {
            var stream = new PiggStream();
            part.writeData(stream, true);
            color.writeData(stream);
            position.writeData(stream);
            item.writeData(stream);
            stream.writeUTF(room);
            stream.position = 0;
            byte[] data = stream.readBytes((int)stream.length);
            FileCompressionUtility util = new FileCompressionUtility();
            byte[] Compresseddata = util.Compress(data);
            return Compresseddata;
        }
        public void Decompress(byte[] cdata)
        {

            FileCompressionUtility zlib = new FileCompressionUtility();
            byte[] data = zlib.uncompress(cdata);
            var stream = new PiggStream(data);
            part.readData(stream, true);
            color.readData(stream);
            position.readData(stream);
            item.readData(stream);
            room = stream.readUTF();

        }

    }
}
