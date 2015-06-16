namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGamePlayResultData : IPacket
    {
        public AmebaStream data;
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

        public void readData(AmebaStream In)
        {
            areaGamePacketId = In.readShort();
            data = new AmebaStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort((short)areaGamePacketId);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        //    Out.writeBytes(BytesConvert.FromHexString("00000000000000000000000000000000000466697368"));
        }
    }
}

