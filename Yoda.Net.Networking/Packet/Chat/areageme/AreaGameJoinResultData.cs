namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;
    
    
    

    public class AreaGameJoinResultData : ICommandData
    {
        public PiggStream bytes;
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

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            isJoinSuccess = In.readBoolean();
            areaGameId = In.readByte();
            areaGameRoomId = In.readInt();
            bytes = new PiggStream();
            bytes.writeBytes(In.readBytes((int)(In.length - In.position)));
            bytes.position = 0;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

