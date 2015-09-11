namespace Yoda.Net.Networking.Packet.Info.AreaGame
{
    
    
    using System;

    public class GetGameInitResultData : ICommandData
    {
        public PiggStream byteArray;
        public int gameId;
        public string kind;


        public GetGameInitResultData()
        {
        }
        public GetGameInitResultData(int gameId, string kind, PiggStream byteArray)
        {
            this.gameId = gameId;
            this.kind = kind;

            this.byteArray = byteArray;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_INIT_RESULT;
            }
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
            Out.writeByte((byte) this.gameId);
            Out.writeUTF(this.kind);

            Out.writeBytes(this.byteArray, (int) this.byteArray.position, (int) (this.byteArray.length - this.byteArray.position));
        }
    }
}

