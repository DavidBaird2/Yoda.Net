namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    

    public class LoginChatResultData : ICommandData
    {
        public bool success;
        public int serverType;

        public LoginChatResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LOGIN_CHAT_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            success = In.readBoolean();
            serverType = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(success);
            Out.writeByte((byte)serverType);
        }
    }
}

