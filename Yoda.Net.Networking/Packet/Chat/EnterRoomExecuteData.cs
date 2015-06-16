namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomExecuteData :  IPacket,IEncrypted
    {
        public string category;
        public string code;
        public int packetId
        {
            get
            {
                return PacketId.ENTER_ROOM_EXECUTE;
            }
        }
        public EnterRoomExecuteData()
        {
            return;
        }



        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
            return;
        }

    }
}

