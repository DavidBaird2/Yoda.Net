namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomExecuteData :  ICommandData,IEncrypted
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



        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
            return;
        }

    }
}

