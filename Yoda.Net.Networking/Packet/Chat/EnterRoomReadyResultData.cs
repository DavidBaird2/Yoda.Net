namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomReadyResultData :  IPacket,IEncrypted
    {
        public string title;
        public int packetId
        {
            get
            {
                return PacketId.ENTER_ROOM_READY_RESULT;
            }
        }
        public EnterRoomReadyResultData()
        {
            return;
        }



        public void readData(AmebaStream In)
        {
            title = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            return;
        }

    }
}

