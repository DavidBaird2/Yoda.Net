namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class ResetRoomData : ICommandData
    {
        public int packetId
        {
            get
            {
                return 818;
            }
        }

        public void readData(PiggStream In)
        {
        }

        public void writeData(PiggStream Out)
        {
        }
    }
}

