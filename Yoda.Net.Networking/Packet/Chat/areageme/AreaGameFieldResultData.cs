namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    
    


    public class AreaGameFieldResultData : IPacket
    {
        public AmebaStream data;
        public int areaGamePacketId;

        public AreaGameFieldResultData(int param1, AmebaStream param2)
        {
            this.areaGamePacketId = param1;
            this.data = param2;
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

        public void readData(AmebaStream In)
        {
            areaGamePacketId = In.readShort();
            data = new AmebaStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(AmebaStream Out)
        {
     //       Engine.Log("AreaGameFieldResultData::writeData  id=" + areaGamePacketId);
            Out.writeShort((short)this.areaGamePacketId);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

