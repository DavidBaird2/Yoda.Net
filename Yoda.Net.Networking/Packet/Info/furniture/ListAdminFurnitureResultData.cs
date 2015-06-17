namespace Yoda.Net.Networking.Packet.Info.furuniture
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Room;
    using Yoda.Net.Networking.Packet.Data.room;

    public class ListAdminFurnitureResultData : IPacket
    {
        public ArrayList furnitures = new ArrayList();

        public int packetId
        {
            get
            {
                return 0x603;
            }
        }

        public void readData(AmebaStream In)
        {
            StockFurniture furniture = null;
            int capacity = 0;
            ArrayList list = null;
            int num2 = 0;
            PartData data = null;
            int num3 = In.readInt();
            this.furnitures = new ArrayList(num3);
            for (int i = 0; i < num3; i++)
            {
                furniture = new StockFurniture {
                    quantity = In.readInt(),
                    characterId = In.readUTF(),
                    category = In.readUTF(),
                    name = In.readUTF(),
                    description = In.readUTF(),
                    actionCode = In.readUTF()
                };
                capacity = In.readShort();
                list = new ArrayList(capacity);
                for (num2 = 0; num2 < capacity; num2++)
                {
                    data = new PartData {
                        height = In.readInt(),
                        attachable = In.readBoolean(),
                        sittable = In.readBoolean(),
                        walkable = In.readBoolean(),
                        wall = In.readByte(),
                        rx = In.readByte(),
                        ry = In.readByte()
                    };
                    list[num2] = data;
                }
                furniture.parts = list;
                furniture.time = In.readDouble();
                this.furnitures[i] = furniture;
            }
        }

        public void writeData(AmebaStream Out)
        {
            int capacity = 0;
            ArrayList list = null;
            int num2 = 0;
            int count = this.furnitures.Count;
            Out.writeInt(count);
            for (int i = 0; i < count; i++)
            {
                StockFurniture furniture = (StockFurniture) this.furnitures[i];
                Out.writeInt(furniture.quantity);
                Out.writeUTF(furniture.characterId);
                Out.writeUTF(furniture.category);
                Out.writeUTF(furniture.name);
                Out.writeUTF(furniture.description);
                Out.writeUTF(furniture.actionCode);
                capacity = furniture.parts.Count;
                Out.writeShort((short) capacity);
                list = new ArrayList(capacity);
                for (num2 = 0; num2 < capacity; num2++)
                {
                    PartData data = (PartData) furniture.parts[num2];
                    Out.writeInt(data.height);
                    Out.writeBoolean(data.attachable);
                    Out.writeBoolean(data.sittable);
                    Out.writeBoolean(data.walkable);
                    Out.writeByte(data.wall);
                    Out.writeByte((byte) data.rx);
                    Out.writeByte((byte) data.ry);
                }
                Out.writeDouble(furniture.time);
            }
        }
    }
}

