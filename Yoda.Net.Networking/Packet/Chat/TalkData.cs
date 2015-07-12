namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    public class TalkData : ICommandData,IEncrypted
    {
        public uint color = 16777215;
        public string message = "";
        public uint balloonColor = 16777215;
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

        public void readData(PiggStream In)
        {
            this.message = In.readUTF();
            this.color = In.readUnsignedInt();
            
            this.balloonColor = In.readUnsignedInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(message);
            Out.writeUnsignedInt(color);
            Out.writeUnsignedInt(this.balloonColor);
        }
    }
}

