


namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class TableGameShowResultData : ICommandData
    {
        public string gameCode;
        public TableGameShowResultData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_SHOW_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            gameCode = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {
            Out.writeUTF(gameCode);
        }


    }
}

