
namespace Yoda.Net.Networking.Packet.Info.gacha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;



    public class GetGachaData : ICommandData, IEncrypted
    {
        public GetGachaData()
        {
        }
        public string shopCode;
        public bool isAdminRequest;

        public int packetId
        {
            get
            {
                return PacketId.GET_GACHA;
            }
        }
        public GetGachaData(string shopCode = null, bool isAdminRequest = false)
        {
            this.shopCode = shopCode;
            this.isAdminRequest = isAdminRequest;
            return;
        } 
        public void readData(PiggStream In)
        {
            shopCode = In.readUTF();
            isAdminRequest = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(shopCode);
            Out.writeBoolean(false);
        }
    }
}

