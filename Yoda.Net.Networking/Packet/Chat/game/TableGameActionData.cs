


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameActionData : IPacket
    {
        public string method;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_ACTION;
            }
        }
        public TableGameActionData(string param1)
        {
            this.method = param1;

            return;
        }

        public void readData(AmebaStream In)
        {
            method = In.readUTF();

            
        }


        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(method);
           
            return;
        }


    }
}

