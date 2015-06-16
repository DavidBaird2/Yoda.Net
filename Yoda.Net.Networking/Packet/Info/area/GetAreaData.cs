namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using Yoda.Net.Networking.Packet.Info;

    public class GetAreaData : IPacket, IEncrypted
    {
        public string code;
        public string category;
        public bool targetUser;
        public bool isShuffleGarden;
        public int packetId
        {
            get
            {
                return PacketId.GET_AREA;
            }
        }
        public GetAreaData(string category, string code)
        {
            this.category = category;
            this.code = code;
            targetUser = false;
            isShuffleGarden = false;
        }
        public GetAreaData()
        {

        }
        public void readData(AmebaStream In)
        {
            category = In.readUTF();
            code = In.readUTF();
            targetUser = In.readBoolean();
            isShuffleGarden = In.readBoolean();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);
            Out.writeBoolean(targetUser);
            Out.writeBoolean(isShuffleGarden);
            return;
        }
    }
}

