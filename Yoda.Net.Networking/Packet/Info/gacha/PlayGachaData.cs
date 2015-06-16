namespace Yoda.Net.Networking.Packet.Info.item
{
    
    using System;
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common;

    public class PlayGachaData : IPacket
    {
        private string _gachaCode;
        private bool _isUseCoupon;

        public PlayGachaData(string gachaCode, bool isUseCoupon)
        {
            _gachaCode = gachaCode;
            _isUseCoupon = isUseCoupon;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.PLAY_GACHA;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_gachaCode);
            Out.writeBoolean(_isUseCoupon);
        }
    }
}

