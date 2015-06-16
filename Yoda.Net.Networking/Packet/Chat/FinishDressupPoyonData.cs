namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;

    public class FinishDressupPoyonData : IPacket,IEncrypted
    {
        public bool updated = false;
        public BodyColorData color;
        public ArrayList items;
        public BodyPartData part;
        public BodyPositionData position;
        public FinishDressupPoyonData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.POYON_FINISH_DRESSUP;
            }
        }

        public void readData(AmebaStream In)
        {
            updated = In.readBoolean();
            if (updated)
            {
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
                    items.Add(In.readUTF());
                }
            }
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeBoolean(updated);
            if (updated)
            {
                Out.writeByte(Convert.ToByte(this.part.gender));
                this.part.writeData(Out);
                this.color.writeData(Out);
                this.position.writeData(Out);

                Out.writeByte((byte)this.items.Count);


                for (int i = 0; i < this.items.Count; i++)
                {
                    string data = (string)this.items[i];

                    Out.writeUTF(data);
                }
            }
        }
    }
}

