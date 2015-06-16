namespace libPigg.net.info.user
{

    using System;
    using System.Drawing;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking.Packet.Info.create;
    public class CreateUserData : IPacket
    {
        private CreateAvatarData _data;
        private Bitmap _thumbnail;
        private byte[] image;
        private string _nickname;
        public CreateUserData()
        {
            _data = new CreateAvatarData();
            return;
        }
        public CreateUserData(CreateAvatarData param1, string nickname ,Bitmap param2 = null )
        {
            _data = param1;
            _thumbnail = param2;
            _nickname = nickname;
            return;
        }
        public int packetId
        {
            get
            {
                return PacketId.CREATE_USER;
            }
        }

        public void readData(AmebaStream In)
        {
            try
            {
                short length = In.readShort();
                image = In.readBytes(length);
                _data.Decompress(In.readBytes((int)(In.length - In.position)));
            }
            catch(Exception e)
            {
              //  Engine.Log(e.ToString());
            }
            return;
        }

        public void writeData(AmebaStream Out)
        {            

          //  var _loc_2:* = _thumbnail.getPixels(new Rectangle(0, 0, _thumbnail.width, _thumbnail.height));
          //  _loc_2.compress();
            Out.writeShort(0);
         //   Out.writeShort((short)image.Length);
          //  Out.writeBytes(image);
         //   Out.writeBytes();
            Out.writeUTF(_nickname);
            Out.writeBytes(_data.binary());
            return;
        }
    }
}

