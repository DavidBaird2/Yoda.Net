namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGameLeaveData : ICommandData
    {
        public int areaGameId;
        public bool enableEntry;
        public int areaGameRoomId;
        public PiggStream byteBuilder;
        public int areaGameOpts;

        public AreaGameLeaveData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_LEAVE;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

