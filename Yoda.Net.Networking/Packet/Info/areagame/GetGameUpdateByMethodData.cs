namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class GetGameUpdateByMethodData : ICommandData
    {
        public GetGameUpdateByMethodData()
        {
        }
        public PiggStream byteArray;
        public int gameId;
        public string kind;
        public string method;

        public GetGameUpdateByMethodData(int gameId, string kind, string method, PiggStream byteArray)
        {
            this.gameId = gameId;
            this.kind = kind;
            this.method = method;
            this.byteArray = byteArray;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_UPDATE_BY_METHOD;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte) this.gameId);
            Out.writeUTF(this.kind);
            Out.writeUTF(this.method);
            Out.writeBytes(this.byteArray, (int) this.byteArray.position, (int) (this.byteArray.length - this.byteArray.position));
        }
    }
}

