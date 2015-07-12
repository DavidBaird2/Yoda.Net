namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class AreaGameFieldResultData : ICommandData
    {
        public PiggStream data;
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

        public void readData(PiggStream In)
        {
            areaGamePacketId = In.readShort();
            data = new PiggStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

