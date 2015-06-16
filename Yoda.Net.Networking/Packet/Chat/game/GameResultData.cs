


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class GameResultData : IPacket
    {
        public int id;
        public AmebaStream data;

        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_RESULT_DATA;
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

        }


    }
}

