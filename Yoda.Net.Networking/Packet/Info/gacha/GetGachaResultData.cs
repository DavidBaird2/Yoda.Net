using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Packet.Data.gacha;



namespace Yoda.Net.Networking.Packet.Info.gacha
{
    public class GetGachaResultData : IPacket
    {
        public int paytType;
        public int point;
        public GachaData gachaData;


        public GetGachaResultData()
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            return;
        }

        public void readData(AmebaStream In)
        {
            gachaData = new GachaData();
            gachaData.readData(In);
      /*      point = In.readInt();
            gachaData.genderCode = In.readInt();
            gachaData.playCount = In.readInt();
            gachaData.isDisEnableCoupon = In.readBoolean();
            gachaData.couponQuantiry = In.readInt();
            gachaData.isEnableDarts = In.readBoolean();
            paytType = gachaData.payType;*/
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_GACHA_RESULT;
            }
        }

    }
}
