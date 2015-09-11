namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class LikeEventResultData : ICommandData
    {
        public LikeEventResultData()
        {
        }
       
        public int packetId
        {
            get
            {
                return PacketId.LIKE_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }


        public void readData(PiggStream In)
        {
            success = In.readBoolean();
            return;
        }
        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(success);
            return;
        }

        public bool success { get; set; }
    }
}

