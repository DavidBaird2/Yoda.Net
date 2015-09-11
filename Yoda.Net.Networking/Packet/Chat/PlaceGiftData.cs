namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class PlaceGiftData : ICommandData
    {

        public PlaceGiftData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.PLACE_GIFT;
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

