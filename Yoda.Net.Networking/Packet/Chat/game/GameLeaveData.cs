


namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class GameLeaveData : ICommandData
    {
        public int gameRoomId;
        public string gameCode;
        public GameLeaveData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_LEAVE;
            }
        }

        public void readData(PiggStream In)
        {
            gameRoomId = In.readInt();
            gameCode = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {
            Out.writeInt(gameRoomId);
            Out.writeUTF(gameCode);
        }


    }
}

