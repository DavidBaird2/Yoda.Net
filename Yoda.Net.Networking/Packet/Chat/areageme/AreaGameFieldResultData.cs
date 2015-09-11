namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;

    public class AreaGameFieldResultData : ICommandData
    {
        public PiggStream data;
        public int areaGamePacketId;

        public AreaGameFieldResultData(int areaGamePacketId, PiggStream data)
        {
            this.areaGamePacketId = areaGamePacketId;
            this.data = data;
        }
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
            Out.writeShort((short)this.areaGamePacketId);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

