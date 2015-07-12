namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    


    public class GiveGoodData : ICommandData
    {
        public string code;

        public GiveGoodData()
        {
        }

        public GiveGoodData(string code)
        {
            this.code = code;
        }

        public int packetId
        {
            get
            {
                return PacketId.GIVE_GOOD;
            }
        }

        public void readData(PiggStream In)
        {
            this.code = In.readUTF();

        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);
        }
    }
}

