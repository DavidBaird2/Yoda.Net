namespace Yoda.Net.Networking.Packet.Info.casino
{
    
    
    using System;
    using System.Collections;
    public class CasinoBuyPointExecuteData : IPacket
    {
        public int buypoint;
        public CasinoBuyPointExecuteData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.CASINO_BUY_POINT_EXECUTE;
            }
        }

        public void readData(AmebaStream In)
        {

            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(buypoint);
            return;
        }
    }
}

