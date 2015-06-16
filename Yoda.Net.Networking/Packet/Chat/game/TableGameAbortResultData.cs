

namespace Yoda.Net.Networking.Packet.Chat.game.data
{

    public class TableGameAbortResultData : IPacket
    {
        public string abortReason;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_ABORT_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            abortReason = In.readUTF();
        }


        public void writeData(AmebaStream Out)
        {

        }


    }
}

