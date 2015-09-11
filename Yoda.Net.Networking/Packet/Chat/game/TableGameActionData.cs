
namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class TableGameActionData : ICommandData
    {
        public string method;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_ACTION;
            }
        }
        public TableGameActionData()
        {

        }
        public TableGameActionData(string method)
        {
            this.method = method;

            return;
        }

        public void readData(PiggStream In)
        {
            method = In.readUTF();

            
        }


        public void writeData(PiggStream Out)
        {
            Out.writeUTF(method);
           
            return;
        }


    }
}

