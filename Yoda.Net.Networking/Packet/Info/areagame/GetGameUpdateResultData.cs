namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class GetGameUpdateResultData : IPacket
    {
        public AmebaStream byteArray;
        public int gameId;
        public string kind;
        public int subPacketId;

        public GetGameUpdateResultData()
        {
        }
        public GetGameUpdateResultData(int param1, string param2, int param3, AmebaStream param4)
        {
            this.gameId = param1;
            this.kind = param2;
            this.subPacketId = param3;
            this.byteArray = param4;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_UPDATE_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            this.gameId = In.readByte();
            this.kind = In.readUTF();
            this.subPacketId = In.readShort();
            AmebaStream array = new AmebaStream();
            this.byteArray = array;
            In.readBytes(array);
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte) this.gameId);
            Out.writeUTF(this.kind);
            Out.writeShort((short)this.subPacketId);
            Out.writeBytes(this.byteArray, (int) this.byteArray.position, (int) (this.byteArray.length - this.byteArray.position));
        }
    }
}

