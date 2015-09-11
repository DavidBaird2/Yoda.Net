namespace Yoda.Net.Networking.Packet.Chat
{
    

    using System;
    using System.Collections;
    
    
    

    public class CheckAreaGameData : ICommandData, IEncrypted
    {
        public string code;
        public string category;
        public CheckAreaGameData(string AreaCategory, string AreaCode)
        {
            code = AreaCode;
            category = AreaCategory;
        }
        public CheckAreaGameData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.CHECK_AREA_GAME;
            }
        }

        public void readData(PiggStream In)
        {
            category = In.readUTF();
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
        }

    }
}

