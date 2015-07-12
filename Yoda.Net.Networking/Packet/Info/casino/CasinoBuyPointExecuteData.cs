namespace Yoda.Net.Networking.Packet.Info.casino
{
    
    
    using System;
    using System.Collections;
    public class CasinoBuyPointExecuteData : ICommandData
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

        public void readData(PiggStream In)
        {

            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(buypoint);
            return;
        }
    }
}

