namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    public class TalkData : IPacket,IEncrypted
    {
        public uint color;
        public string message;
        public uint balloonColor;
        public TalkData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.TALK;
            }
        }

        public void readData(AmebaStream In)
        {
            this.message = In.readUTF();
            this.color = In.readUnsignedInt();
            
            this.balloonColor = In.readUnsignedInt();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(message);
            Out.writeUnsignedInt(color);
            Out.writeUnsignedInt(this.balloonColor);
        }
    }
}

