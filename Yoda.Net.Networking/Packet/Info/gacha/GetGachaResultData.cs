using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Gacha;



namespace Yoda.Net.Networking.Packet.Info.gacha
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
            return;
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
            /*
            gachaData = new GachaData();
            gachaData.readData(In);
            */
       
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
