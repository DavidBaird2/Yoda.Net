namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    public class TableGameTalkResultData : ICommandData
    {

        public uint color;
        public string hexCode;
        public string message;
        public string nickname;


        public int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_TALK_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(hexCode);
            Out.writeUTF(nickname);
            Out.writeUTF(message);
            Out.writeUnsignedInt(color);
       
        }
    }
}

