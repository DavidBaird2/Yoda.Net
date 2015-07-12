namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using System;
    using Yoda.Net.Networking.Packet;


    public class FinishShopData : ICommandData
    {


        public FinishShopData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.FINISH_SHOP;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

