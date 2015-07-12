


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameData : ICommandData
    {
        public string method;
        public PiggStream data;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME;
            }
        }
        public TableGameData(string method, PiggStream data)
        {
            this.method = method;
            this.data = data;
            return;
        }
        public TableGameData()
        {
            data = new PiggStream();
            return;
        }
        public void readData(PiggStream In)
        {
            method = In.readUTF();
            if (In.readBoolean())
            {
                data.writeBytes(In.readBytes((int)(In.length - In.position)));
            }
            
        }


        public void writeData(PiggStream Out)
        {

            Out.writeUTF(method);
            if (data != null)
            {
                Out.writeBoolean(true);
                data.position = 0;
                Out.writeBytes(data.readBytes((int)data.length));
            }
            else
            {
                Out.writeBoolean(false);
            }
            return;
        }


    }
}

