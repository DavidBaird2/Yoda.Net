


namespace Yoda.Net.Networking.Packet.Chat.game.data
{

    public class GameData : IPacket
    {
        public int id;
        public AmebaStream data;

        public GameData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_DATA;
            }
        }

        public void readData(AmebaStream In)
        {
            id = In.readShort();
            data = new AmebaStream();
            data.writeBytes(In.readBytes((int)(In.length - In.BaseStream.Position)));
            data.position = 0;
            
        }


        public void writeData(AmebaStream Out)
        {
           // Engine.Log("writeData:onGame::"+ id+ data.position+ data.length);
            Out.writeInt(id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
            return;
        }


    }
}

