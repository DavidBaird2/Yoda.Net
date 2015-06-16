namespace Yoda.Net.Networking.Packet.Info.furuniture
{
    

    using System;
    using System.Collections;
    
    using Yoda.Net.Networking.Packet.Data.room;

    public class ListUserFurnitureResultData : IPacket
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

        public void readData(AmebaStream In)
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
            int _loc_4 = In.readInt();
            placedFurnitures = new Hashtable();
            int _loc_3 = 0;
            while (_loc_3 < _loc_4)
            {

                string _loc_10 = In.readUTF();
               int _loc_11 = In.readInt();
                placedFurnitures[_loc_10] = new ArrayList(_loc_11);
              int  _loc_8 = 0;
                while (_loc_8 < _loc_11)
                {

                    var _loc_12 = new Hashtable();
                    _loc_12["category"] = In.readUTF();
                    _loc_12["code"] = In.readUTF();
                    ((ArrayList)placedFurnitures[_loc_10]).Add(_loc_12);
                    _loc_8++;
                }
                _loc_3++;
            }
        }

        public void writeData(AmebaStream Out)
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

