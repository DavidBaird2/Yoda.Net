namespace Yoda.Net.Networking.Packet.Info.furuniture
{


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Room;

    public class ListUserFurnitureResultData : ICommandData
    {
        public ArrayList furnitures = new ArrayList();
        public int max;
        public Hashtable placedFurnitures;
        public int roomNum;
        public int packetId
        {
            get
            {
                return PacketId.LIST_USER_FURNITURE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            StockFurniture furniture = null;
            int capacity = 0;
            ArrayList list = null;
            int num2 = 0;
            PartData data = null;
            max = In.readInt();
            int num3 = In.readInt();
            this.furnitures = new ArrayList(num3);
            for (int i = 0; i < num3; i++)
            {
                furniture = new StockFurniture {
                    quantity = In.readInt(),
                    characterId = In.readUTF(),
                    type = In.readByte(),
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
                    list.Insert(num2, data);
                }
                furniture.parts = list;
                furniture.time = In.readDouble();
                this.furnitures.Insert(i,furniture);
            }
            int placecount = In.readInt();
            placedFurnitures = new Hashtable();
            int num = 0;
            while (num < placecount)
            {

                string code = In.readUTF();
               int num6 = In.readInt();
                placedFurnitures[code] = new ArrayList(num6);
              int  i = 0;
                while (i < num6)
                {

                    var _loc_12 = new Hashtable();
                    _loc_12["category"] = In.readUTF();
                    _loc_12["code"] = In.readUTF();
                    ((ArrayList)placedFurnitures[code]).Add(_loc_12);
                    i++;
                }
                num++;
            }
        }

        public void writeData(PiggStream Out)
        {
            int capacity = 0;
            ArrayList list = null;
            int num2 = 0;
            Out.writeInt(max);
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
            Out.writeInt(placedFurnitures.Count);
            foreach (string code in placedFurnitures.Keys)
            {
                ArrayList placed = (ArrayList)placedFurnitures[code];
                Out.writeUTF(code);
                Out.writeInt(placed.Count);
                foreach (Hashtable d in placed)
                {
                    Out.writeUTF(d["category"].ToString());

                    Out.writeUTF(d["code"].ToString());
                }
            }
        }
    }
}

