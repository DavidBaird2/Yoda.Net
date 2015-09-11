
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class LeaveUserData : ICommandData
    {
        public string code;

        public int packetId
        {
            get
            {
                return 0x220;
            }
        }

        public void readData(PiggStream In)
        {
            this.code = In.readUTFBytes(0x10);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(code);
        }
    }
}

