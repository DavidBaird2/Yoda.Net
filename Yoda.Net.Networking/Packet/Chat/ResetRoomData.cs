namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class ResetRoomData : IPacket
    {
        public int packetId
        {
            get
            {
                return 818;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

