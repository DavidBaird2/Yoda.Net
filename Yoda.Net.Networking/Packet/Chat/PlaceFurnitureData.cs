
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    

    public class PlaceFurnitureData : ICommandData, IEncrypted
    {
        public string code;
        public int dir;
        public int x;
        public int y;
        public int z;

        public PlaceFurnitureData()
        {
        }

        public PlaceFurnitureData(string code, int x, int y, int z, int dir)
        {
            this.code = code;
            this.x = x;
            this.y = y;
            this.z = z;
            this.dir = dir;
        }

        public int packetId
        {
            get
            {
                return PacketId.PLACE_FURNITURE;
            }
        }

        public void readData(PiggStream In)
        {
            this.code = In.readUTF();
            this.dir = In.readByte();
            this.x = In.readInt();
            this.y = In.readInt();
            this.z = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);
            Out.writeByte((byte) this.dir);
            Out.writeInt(this.x);
            Out.writeInt(this.y);
            Out.writeInt(this.z);
            Out.writeBoolean(false);
        }
    }
}

