namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;


    public class UpdateNumFootPrintTodayData : ICommandData
    {
        public int num;
    

        
        public UpdateNumFootPrintTodayData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.UPDATE_NUM_FOOTPRINT_TODAY;
            }
        }

        public void readData(PiggStream In)
        {
            num = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(num);
        }
    }
}

