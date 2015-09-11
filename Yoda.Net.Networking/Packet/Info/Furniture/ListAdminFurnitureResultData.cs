namespace Yoda.Net.Networking.Packet.Info.Furniture
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Room;
    public class ListAdminFurnitureResultData : ICommandData
    {
        public ArrayList furnitures = new ArrayList();

        public int packetId
        {
            get
            {
                return 0x603;
            }
        }

        public void readData(PiggStream In)
        {
            StockFurniture furniture = null;
            int capacity = 0;
            ArrayList list = null;

            PartData data = null;
            int n = In.readInt();
            this.furnitures = new ArrayList(n);
            for (int i = 0; i < n; i++)
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
                for (i = 0; i < capacity; i++)
                {
                    data.readData(In, false);
                    list[i] = data;
                }
                furniture.parts = list;
                furniture.time = In.readDouble();
                this.furnitures[i] = furniture;
            }
        }

        public void writeData(PiggStream Out)
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
                    data.writeData(Out, false);
                }
                Out.writeDouble(furniture.time);
            }
        }
    }
}

