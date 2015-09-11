namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;

    using Yoda.Net.Networking.Packet.Info;

    using System.Drawing;
    using System.Collections;

    using System.Windows.Forms;
    using System.IO;
    using Yoda.Net.Networking;
    using Yoda.Net.Common;

    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Data.Common;

    public class DressupData : ICommandData
    {
        public bool changedBody;
        public BodyColorData color;
        public ArrayList items;
        public BodyPartData part;
        public BodyPositionData position;
        public object thumbnail;
        public bool isFinishTutorial = true;
        public int packetId
        {
            get
            {
                return PacketId.DRESSUP;
            }
        }


        public void readData(PiggStream In)
        {


            int lengh = In.readShort();
            if (lengh != 0)
            {
                byte[] CompressedImage = In.readBytes(lengh);

                // 入出力用のストリームを生成します 
                FileCompressionUtility zlib = new FileCompressionUtility();
                byte[] body = zlib.uncompress(CompressedImage);

            }
            part = new BodyPartData();
            color = new BodyColorData();
            position = new BodyPositionData();
            items = new ArrayList();
            this.part.gender = In.readByte();
            this.part.readData(In);
            this.color.readData(In);
            this.position.readData(In);
            int count = In.readByte();
            for (int i = 0; i < count; i++)
            {
                UserItemData data = new UserItemData();
                data.id = In.readInt();
                items.Add(data);
            }
            this.changedBody = In.readBoolean();
            isFinishTutorial = In.readBoolean();
        }


        public void writeData(PiggStream Out)
        {
            UserItemData data = null;
            if (this.thumbnail == null)
            {
                Out.writeShort(0);
            }
            else
            {


                throw new NotImplementedException();

            }
            Out.writeByte(Convert.ToByte(this.part.gender));
            this.part.writeData(Out);
            this.color.writeData(Out);
            this.position.writeData(Out);
            if (this.items.Count > 120)
            {
                Out.writeByte(120);
            }
            else
            {
                Out.writeByte((byte)this.items.Count);
            }
            for (int i = 0; i < this.items.Count; i++)
            {
                data = this.items[i] as UserItemData;
                Out.writeInt(data.id);

                if (i == 120)
                    break;
            }
            Out.writeBoolean(this.changedBody);
            Out.writeBoolean(this.isFinishTutorial);
        }
    }
}

