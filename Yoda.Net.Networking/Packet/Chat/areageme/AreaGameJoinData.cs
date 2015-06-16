namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    

    public class AreaGameJoinData : IPacket
    {
        public int areaGameId;
        public bool enableEntry;
        public int areaGameRoomId;
        public AmebaStream byteBuilder;
        public int areaGameOpts;
        public AreaGameJoinData()
        {

        }
        public AreaGameJoinData(int areaGameRoomId = 0, int areaGameId = 0, bool enableEntry = true, int areaGameOpts = 0, AmebaStream byteBuilder = null)
        {
            this.areaGameRoomId = areaGameRoomId;
            this.areaGameId = areaGameId;
            this.enableEntry = enableEntry;
            this.areaGameOpts = areaGameOpts;
            this.byteBuilder = byteBuilder;
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_JOIN;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {   
            Out.writeInt(areaGameRoomId);
            Out.writeByte((byte)areaGameId);
            Out.writeBoolean(enableEntry);
            Out.writeInt(areaGameOpts);
            byteBuilder.position = 0;
            Out.writeBytes(byteBuilder.readBytes((int)byteBuilder.BaseStream.Length));
        }
    }
}

