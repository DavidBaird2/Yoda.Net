


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameShowResultData : IPacket
    {
        public string gameCode;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_SHOW_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            gameCode = In.readUTF();
        }


        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(gameCode);
        }


    }
}

