
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common.test;
using Yoda.Net.Networking.Packet.Data.common;

    public class ListBundleTravelAreaResultData : IPacket
    {
        public string categoryName;
        public List<TravelAreaData> bundleList;
        public TravelAreaData areaData;
        public bool isEnterable;
        public string enterableDescription;
        public string ticketShopCode;

        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_AREA_RESULT;
            }
        }

        public void readData(AmebaStream param1)
        {
         this.categoryName = param1.readUTF();
            var _loc_2 = param1.readInt();
            this.bundleList = new List<TravelAreaData>(_loc_2);
            var _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {
                
                this.areaData = new TravelAreaData();
                this.areaData.categoryCode = param1.readUTF();
                this.areaData.code = param1.readUTF();
                this.areaData.name = param1.readUTF();
                this.areaData.description = param1.readUTF();
                this.areaData.capacity = param1.readInt();
                this.areaData.currentCount = param1.readInt();
                this.areaData.condition = param1.readByte();
                this.bundleList.Add(this.areaData);
                _loc_3++;
            }
            this.isEnterable = param1.readBoolean();
            if (!this.isEnterable)
            {
                this.enterableDescription = param1.readUTF();
                this.ticketShopCode = param1.readUTF();
            }
            return;
        }


        public void writeData(AmebaStream Out)
        {
        }
    }
}

