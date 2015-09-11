namespace Yoda.Net.Networking.Packet.Info.AreaGame
{
    
    
    using System;
    

    public class GetGameInitData : ICommandData
    {
        public PiggStream byteArray;
        public int gameId;
        public string kind;

        public GetGameInitData(int gameId, string kind, PiggStream stream)
        {
            this.gameId = gameId;
            this.kind = kind;
            this.byteArray = stream;
        }
        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_INIT;
            }
        }
        public GetGameInitData()
        {
            byteArray = new PiggStream();
        }
        public void readData(PiggStream In)
        {


            this.gameId = In.readByte();
            this.kind = In.readUTF();

            PiggStream array = new PiggStream();
            this.byteArray = array;
            In.readBytes(array);

        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte)this.gameId);
            Out.writeUTF(this.kind);
            Out.writeBytes(this.byteArray, (int)this.byteArray.position, (int)(this.byteArray.length - this.byteArray.position));
        }
    }
}

