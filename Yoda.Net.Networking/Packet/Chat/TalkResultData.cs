namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
using System.Runtime.InteropServices;
    
    public class TalkResultData : ICommandData
    {




        static bool HandlerFunc() {
            return false;
        }
        

        public string amebaId;
        public uint color;
        public string hexCode;
        public string message;
        public string nickname;
        public uint balloonColor;
        public int roomIndex;
        public int packetId
        {
            get
            {
                return PacketId.TALK_RESULT;
            }
        }

        public void readData(PiggStream In)
        {


            this.hexCode = In.readUTFBytes(0x10);
            this.message = In.readUTF();
            this.color = In.readUnsignedInt();
            this.amebaId = In.readUTF();
            this.nickname = In.readUTF();
            this.balloonColor = In.readUnsignedInt();
            roomIndex = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(hexCode);
            Out.writeUTF(message);
            Out.writeUnsignedInt(color);
            Out.writeUTF(amebaId);
            Out.writeUTF(nickname);
            Out.writeUnsignedInt(this.balloonColor);
            Out.writeInt(roomIndex);
        }
    }
}

