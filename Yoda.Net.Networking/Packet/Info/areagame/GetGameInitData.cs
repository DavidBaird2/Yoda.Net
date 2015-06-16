namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;
    

    public class GetGameInitData : IPacket
    {
        public AmebaStream byteArray;
        public int gameId;
        public string kind;

        public GetGameInitData(int param1, string param2, AmebaStream param4)
        {
            this.gameId = param1;
            this.kind = param2;
            this.byteArray = param4;
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
            byteArray = new AmebaStream();
        }
        public void readData(AmebaStream In)
        {


            this.gameId = In.readByte();
            this.kind = In.readUTF();

            AmebaStream array = new AmebaStream();
            this.byteArray = array;
            In.readBytes(array);

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte)this.gameId);
            Out.writeUTF(this.kind);
            Out.writeBytes(this.byteArray, (int)this.byteArray.position, (int)(this.byteArray.length - this.byteArray.position));
        }
    }
}

