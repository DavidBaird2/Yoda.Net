namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;
    using System.Collections;
    

    public class PlaceActionItemResultData : IPacket
    {
        public int sequence;
        public int actionItemType;
        public string type;
        public string code;
        public string userCode;
        public int y;
        public int z;
        public int x;

        public int packetId
        {
            get
            {
                return PacketId.PLACE_ACTION_ITEM_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            type = In.readUTF();
            code = In.readUTF();
            userCode = In.readUTF();
            sequence = In.readInt();
            actionItemType = In.readByte();
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(type);
            Out.writeUTF(code);
            Out.writeUTF(userCode);
            Out.writeInt(sequence);
            Out.writeByte((byte)actionItemType);
            Out.writeShort((short) x);
            Out.writeShort((short)y);
            Out.writeShort((short)z);
        }
    }
}

