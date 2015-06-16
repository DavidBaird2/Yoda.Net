namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterQueueResultData :  IPacket,IEncrypted
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



        public void readData(AmebaStream In)
        {
            current = In.readInt();
            return;
        }

        public void writeData(AmebaStream Out)
        {

            return;
        }

    }
}

