namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    


    public class GiveGoodData : IPacket
    {
        public string code;

        public GiveGoodData()
        {
        }

        public GiveGoodData(string param1)
        {
            this.code = param1;
        }

        public int packetId
        {
            get
            {
                return PacketId.GIVE_GOOD;
            }
        }

        public void readData(AmebaStream In)
        {
            this.code = In.readUTF();

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.code);
        }
    }
}

