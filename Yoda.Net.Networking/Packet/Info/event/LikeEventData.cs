namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class LikeEventData : IPacket
    {
        public string _userCode;
        public int packetId
        {
            get
            {
                return PacketId.LIKE_NOTICE_BOARD_MESSAGE;
            }
        }
        public LikeEventData(string userCode)
        {
            _userCode = userCode;
        }
        public void readData(AmebaStream In)
        {
            _userCode = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_userCode);
            return;
        }
    }
}

