


namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{

    public class GameData : ICommandData
    {
        public int id;
        public PiggStream data;

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

        public void readData(PiggStream In)
        {
            id = In.readShort();
            data = new PiggStream();
            data.writeBytes(In.readBytes((int)(In.length - In.BaseStream.Position)));
            data.position = 0;
            
        }


        public void writeData(PiggStream Out)
        {
            Out.writeInt(id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
            return;
        }


    }
}

