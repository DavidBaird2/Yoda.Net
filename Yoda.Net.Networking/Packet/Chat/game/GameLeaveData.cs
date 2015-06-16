


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class GameLeaveData : IPacket
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

        public void readData(AmebaStream In)
        {
            gameRoomId = In.readInt();
            gameCode = In.readUTF();
        }


        public void writeData(AmebaStream Out)
        {
            Out.writeInt(gameRoomId);
            Out.writeUTF(gameCode);
        }


    }
}

