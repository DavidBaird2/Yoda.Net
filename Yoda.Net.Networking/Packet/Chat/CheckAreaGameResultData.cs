namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    using System.Collections;
    
    
    

    public class CheckAreaGameResultData : ICommandData, IEncrypted
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

        public void readData(PiggStream In)
        {
            areaGameId = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte)areaGameId);
        }

    }
}

