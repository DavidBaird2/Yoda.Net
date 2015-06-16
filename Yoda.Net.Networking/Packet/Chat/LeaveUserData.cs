
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class LeaveUserData : IPacket
    {
        public string code;

        public int packetId
        {
            get
            {
                return 0x220;
            }
        }

        public void readData(AmebaStream In)
        {
            this.code = In.readUTFBytes(0x10);
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTFBytes(code);
        }
    }
}

