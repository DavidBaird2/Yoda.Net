namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    

    public class ChangeRoomData : ICommandData, IEncrypted
    {
        public int type;
        public string code;

        public ChangeRoomData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.CHANGE_ROOM;
            }
        }

        public void readData(PiggStream In)
        {
            type = In.readByte();
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte)type);
            Out.writeUTF(code);
        }
    }
}

