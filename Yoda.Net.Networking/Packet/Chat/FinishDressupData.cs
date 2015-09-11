namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    
    


    public class FinishDressupData : ICommandData
    {
        public bool updated = false;

        public FinishDressupData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.FINISH_DRESSUP;
            }
        }

        public void readData(PiggStream In)
        {
            updated = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(updated);
        }
    }
}

