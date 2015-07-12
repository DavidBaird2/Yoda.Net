namespace Yoda.Net.Networking.Packet.Info.item
{
    
    using System;
    
    using System.Collections;

    public class PlayGachaData : ICommandData
    {
        public PlayGachaData()
        {
        }
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

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(_gachaCode);
            Out.writeBoolean(_isUseCoupon);
        }
    }
}

