namespace Yoda.Net.Networking.Packet.Chat
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Room;

    public class PlaceFurnitureResultData : ICommandData
    {
        public DefineFurniture define;
        public PlaceFurniture place;

        public int packetId
        {
            get
            {
                return 0x301;
            }
        }

        public void readData(PiggStream In)
        {
     
            this.place = new PlaceFurniture();
            this.place.sequence = In.readInt();
            this.place.x = (short) In.readInt();
            this.place.y = (short) In.readInt();
            this.place.z = (short) In.readInt();
            this.place.direction = In.readByte();
            this.place.ownerId = In.readUTF();
            int capacity = In.readShort();
            DefineFurniture furniture = new DefineFurniture();
            string str = In.readUTF();
            this.place.characterId = str;
            furniture.characterId = str;
            furniture.type = In.readByte();
            furniture.category = In.readUTF();
            furniture.name = In.readUTF();
            furniture.description = In.readUTF();
            furniture.actionCode = In.readUTF();
            furniture.parts = new List<PartData>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                PartData data = new PartData();
                    data.readData(In, true);
                furniture.parts.Insert(i, data);
            }
            this.define = furniture;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.place.sequence);
            Out.writeInt(this.place.x);
            Out.writeInt(this.place.y);
            Out.writeInt(this.place.z);
            Out.writeByte((byte) this.place.direction);
            Out.writeUTF(this.place.ownerId);
            int count = this.define.parts.Count;
            Out.writeShort((short) count);
            Out.writeUTF(this.place.characterId);
            Out.writeByte((byte)this.define.type);
            Out.writeUTF(this.define.category);
            Out.writeUTF(this.define.name);
            Out.writeUTF(this.define.description);
            Out.writeUTF(this.define.actionCode);
            for (int i = 0; i < count; i++)
            {
                PartData data = (PartData) this.define.parts[i];
                data.writeData(Out, true);
            }
        }
    }
}

