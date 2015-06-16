


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class GameReadyData : IPacket
    {

        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_READY;
            }
        }

        public void readData(AmebaStream In)
        {
        }


        public void writeData(AmebaStream Out)
        {

        }


    }
}

