


namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class GameJoinData : ICommandData
    {
        public int opts;
        public int gameRoomId;
        public bool enableEntry;
        public string gameCode;
        public GameJoinData()
        {
        }
        public GameJoinData(int gameRoomId, string gameCode, bool enableEntry, int opts)
        {
            this.opts = opts;
            this.gameRoomId = gameRoomId;
            this.enableEntry = enableEntry;
            this.gameCode = gameCode;
        }
        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_JOIN;
            }
        }

        public void readData(PiggStream In)
        {
            this.gameRoomId = In.readInt();
            this.gameCode = In.readUTF();
            this.enableEntry = In.readBoolean();
            this.opts = In.readInt();

        }


        public void writeData(PiggStream Out)
        {
            Out.writeInt(gameRoomId);
            Out.writeUTF(gameCode);
            Out.writeBoolean(enableEntry);
            Out.writeInt(opts);
        }


    }
}

