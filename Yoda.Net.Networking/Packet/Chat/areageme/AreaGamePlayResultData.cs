namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGamePlayResultData : ICommandData
    {
        public PiggStream data;
        public int areaGamePacketId;


        public AreaGamePlayResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_PLAY_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            areaGamePacketId = In.readShort();
            data = new PiggStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort((short)areaGamePacketId);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

