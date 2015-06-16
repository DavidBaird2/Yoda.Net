
namespace Yoda.Net.Networking.Packet.Info.gacha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetGachaData : IPacket, IEncrypted
    {
        public string shopCode;
        public bool isAdminRequest;

        public int packetId
        {
            get
            {
                return PacketId.GET_GACHA;
            }
        }
        public GetGachaData(string param1 = null,  bool param2 = false)
        {
            this.shopCode = param1;
            this.isAdminRequest = param2;
            return;
        } 
        public void readData(AmebaStream In)
        {
            shopCode = In.readUTF();
            isAdminRequest = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(shopCode);
            Out.writeBoolean(false);
        }
    }
}

