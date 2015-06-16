namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    using System.Collections;
    
    
    

    public class CheckAreaGameData : IPacket, IEncrypted
    {
        public string code;
        public string category;
        public CheckAreaGameData(string AreaCategory, string AreaCode)
        {
            code = AreaCode;
            category = AreaCategory;
        }
        public virtual int packetId
        {
            get
            {
                return PacketId.CHECK_AREA_GAME;
            }
        }

        public void readData(AmebaStream In)
        {
            category = In.readUTF();
            code = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
        }

    }
}

