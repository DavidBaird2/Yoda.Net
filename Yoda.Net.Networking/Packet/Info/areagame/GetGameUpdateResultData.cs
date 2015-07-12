namespace Yoda.Net.Networking.Packet.Info.areagame
{
    
    
    using System;

    public class GetGameUpdateResultData : ICommandData
    {
        public PiggStream byteArray;
        public int gameId;
        public string kind;
        public int subPacketId;

        public GetGameUpdateResultData()
        {
        }
        public GetGameUpdateResultData(int gameId, string kind, int subPacketId, PiggStream byteArray)
        {
            this.gameId = gameId;
            this.kind = kind;
            this.subPacketId = subPacketId;
            this.byteArray = byteArray;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GAME_UPDATE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.gameId = In.readByte();
            this.kind = In.readUTF();
            this.subPacketId = In.readShort();
            PiggStream array = new PiggStream();
            this.byteArray = array;
            In.readBytes(array);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte) this.gameId);
            Out.writeUTF(this.kind);
            Out.writeShort((short)this.subPacketId);
            Out.writeBytes(this.byteArray, (int) this.byteArray.position, (int) (this.byteArray.length - this.byteArray.position));
        }
    }
}

