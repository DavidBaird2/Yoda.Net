namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGameLeaveData : IPacket
    {
        public int areaGameId;
        public bool enableEntry;
        public int areaGameRoomId;
        public AmebaStream byteBuilder;
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

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {   
           
        }
    }
}

