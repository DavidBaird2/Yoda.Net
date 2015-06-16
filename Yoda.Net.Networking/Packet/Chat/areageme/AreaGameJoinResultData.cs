namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    

    public class AreaGameJoinResultData : IPacket
    {
        public AmebaStream bytes;
        public bool isJoinSuccess;
        public int areaGameRoomId;
        public string userCode;
        public int areaGameId;


        public AreaGameJoinResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_JOIN_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            userCode = In.readUTF();
            isJoinSuccess = In.readBoolean();
            areaGameId = In.readByte();
            areaGameRoomId = In.readInt();
            bytes = new AmebaStream();
            bytes.writeBytes(In.readBytes((int)(In.length - In.position)));
            bytes.position = 0;
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

