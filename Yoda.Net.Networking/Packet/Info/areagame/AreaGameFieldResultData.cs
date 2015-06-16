namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class AreaGameFieldResultData : IPacket
    {
        public AmebaStream data;
        public int areaGamePacketId;


        public AreaGameFieldResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_FIELD_RESULT;
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
        }
    }
}

