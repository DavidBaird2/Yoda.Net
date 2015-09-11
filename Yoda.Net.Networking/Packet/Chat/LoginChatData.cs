namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    
    

    public class LoginChatData : ICommandData,IEncrypted
    {
        public string amebaId;
        public byte[] secure;
        public int connectionId;

        public LoginChatData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LOGIN_CHAT;
            }
        }

        public void readData(PiggStream In)
        {
            amebaId = In.readUTF();
            secure = In.readBytes(8);
            connectionId = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(amebaId);
            Out.writeBytes(secure);
            Out.writeInt(connectionId);
        }
    }
}

