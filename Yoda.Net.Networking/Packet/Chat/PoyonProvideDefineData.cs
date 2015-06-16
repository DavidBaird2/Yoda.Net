
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.room;
    public class PoyonProvideDefineData : IPacket, IEncrypted
    {
        public ArrayList DefineList;
        public PoyonProvideDefineData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.POYON_PROVIDE_DEFINE;
            }
        }

        public void readData(AmebaStream In)
        {
            int count = In.readInt();

            for (int n = 0; n < count; n++)
            {


                PartData data = null;
                DefineFurniture furniture = new DefineFurniture();
                int capacity = In.readShort();
                string str = In.readUTF();
                furniture.characterId = str;
                furniture.category = In.readUTF();
                furniture.name = In.readUTF();
                furniture.description = In.readUTF();
                furniture.actionCode = In.readUTF();
                furniture.parts = new ArrayList(capacity);
                for (int i = 0; i < capacity; i++)
                {
                    data = new PartData
                    {
                        height = In.readInt(),
                        attachable = In.readBoolean(),
                        sittable = In.readBoolean(),
                        walkable = In.readBoolean(),
                        wall = In.readByte(),
                        attachDirection = In.readByte(),
                        rx = In.readByte(),
                        ry = In.readByte()
                    };
                    furniture.parts.Insert(i, data);
                }
                //  DefineList.Add(furniture);
                DefineList.Add(furniture);
            }
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(DefineList.Count);
            foreach (DefineFurniture define in DefineList)
            {

                int count = define.parts.Count;
                Out.writeShort((short)count);
                Out.writeUTF(define.characterId);
                Out.writeUTF(define.category);
                Out.writeUTF(define.name);
                Out.writeUTF(define.description);
                Out.writeUTF(define.actionCode);
                for (int i = 0; i < count; i++)
                {
                    PartData data = (PartData)define.parts[i];
                    Out.writeInt(data.height);
                    Out.writeBoolean(data.attachable);
                    Out.writeBoolean(data.sittable);
                    Out.writeBoolean(data.walkable);
                    Out.writeByte(data.wall);
                    Out.writeByte((byte)data.attachDirection);
                    Out.writeByte((byte)data.rx);
                    Out.writeByte((byte)data.ry);
                }
            }
        }
    }
}

