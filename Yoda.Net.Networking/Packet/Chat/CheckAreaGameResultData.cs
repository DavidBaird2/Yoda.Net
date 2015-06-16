namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    using System.Collections;
    
    
    

    public class CheckAreaGameResultData : IPacket, IEncrypted
    {
        public int areaGameId;
        public CheckAreaGameResultData()
        {
        }
        public virtual int packetId
        {
            get
            {
                return PacketId.CHECK_AREA_GAME_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            areaGameId = In.readByte();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte)areaGameId);
        }

    }
}

