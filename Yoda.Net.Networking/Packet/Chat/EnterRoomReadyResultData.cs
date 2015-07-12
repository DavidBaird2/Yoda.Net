namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomReadyResultData :  ICommandData,IEncrypted
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



        public void readData(PiggStream In)
        {
            title = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(title);
        
        }

    }
}

