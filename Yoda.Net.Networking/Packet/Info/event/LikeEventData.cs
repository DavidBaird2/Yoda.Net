namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class LikeEventData : ICommandData
    {
        public LikeEventData()
        {
        }
        public string userCode;
        public int packetId
        {
            get
            {
                return PacketId.LIKE_NOTICE_BOARD_MESSAGE;
            }
        }
        public LikeEventData(string userCode)
        {
           this.userCode = userCode;
        }
        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(userCode);
            return;
        }
    }
}

