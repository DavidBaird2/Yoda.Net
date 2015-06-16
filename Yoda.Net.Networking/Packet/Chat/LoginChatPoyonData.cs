
using Yoda.Net.Networking.Packet.Data.common;
using Yoda.Net.Networking.Packet.Data.room;
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    

    public class LoginChatPoyonData : IPacket, IEncrypted
    {
        public string amebaId;
        public byte[] secure;
        public int connectionId;
        public DefineAvatar define;
        public LoginChatPoyonData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.POYON_LOGIN_CHAT;
            }
        }

        public void readData(AmebaStream In)
        {
            amebaId = In.readUTF();
            secure = In.readBytes(8);
            connectionId = In.readInt();
            define = new DefineAvatar();
            define.data = new AvatarData();
            define.data.readData(In);
            define.characterId = define.data.userCode;
            define.name = define.data.amebaId;
            define.part = new PartData
            {
                height = 0x60
            };
           
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(amebaId);
            Out.writeBytes(secure);
            Out.writeInt(connectionId);
            define.data.writeData(Out);

        }
    }
}

