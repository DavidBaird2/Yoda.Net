namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterQueueResultData :  ICommandData,IEncrypted
    {
        public int current;

        public int packetId
        {
            get
            {
                return PacketId.ENTER_QUEUE_RESULT;
            }
        }
        public EnterQueueResultData()
        {
            return;
        }



        public void readData(PiggStream In)
        {
            current = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(current);
            return;
        }

    }
}

