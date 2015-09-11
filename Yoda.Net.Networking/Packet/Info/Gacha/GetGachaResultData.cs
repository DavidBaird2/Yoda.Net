using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Gacha;



namespace Yoda.Net.Networking.Packet.Info.Gacha
{
    public class GetGachaResultData : ICommandData
    {
        public int paytType;
        public int point;
        public GachaData gachaData;


        public GetGachaResultData()
        {
            return;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
            
        }

        public void readData(PiggStream In)
        {

            this.gachaData = new GachaData();
            this.gachaData.readData(In);

            this.paytType = this.gachaData.payType;
            this.point = this.gachaData.point;
       
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
