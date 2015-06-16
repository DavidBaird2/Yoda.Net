namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class GetGameUpdateByMethodData : IPacket
    {
        public AmebaStream byteArray;
        public int gameId;
        public string kind;
        public string method;

        public GetGameUpdateByMethodData(int param1, string param2, string param3, AmebaStream param4)
        {
            this.gameId = param1;
            this.kind = param2;
            this.method = param3;
            this.byteArray = param4;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_UPDATE_BY_METHOD;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte) this.gameId);
            Out.writeUTF(this.kind);
            Out.writeUTF(this.method);
            Out.writeBytes(this.byteArray, (int) this.byteArray.position, (int) (this.byteArray.length - this.byteArray.position));
        }
    }
}

