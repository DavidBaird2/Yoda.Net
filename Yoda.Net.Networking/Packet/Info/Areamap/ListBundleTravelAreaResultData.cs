
namespace Yoda.Net.Networking.Packet.Info.Areamap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;

    public class ListBundleTravelAreaResultData : ICommandData
    {
        public string categoryName;
        public List<TravelAreaData> bundleList;
        public TravelAreaData areaData;
        public bool isEnterable;
        public string enterableDescription;
        public string ticketShopCode;
        public sbyte requestModule;
        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_BUNDLE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
         this.categoryName = In.readUTF();
            var totalCount = In.readInt();
            this.bundleList = new List<TravelAreaData>(totalCount);
            var i = 0;
            while (i < totalCount)
            {

                this.areaData = new TravelAreaData();
                this.areaData.categoryCode = In.readUTF();
                this.areaData.areaCode = In.readUTF();
                this.areaData.name = In.readUTF();
                this.areaData.description = In.readUTF();
                this.areaData.capacity = In.readInt();
                this.areaData.currentCount = In.readInt();
                this.areaData.condition = In.readByte();
       
                this.bundleList.Add(this.areaData);
                i++;
            }
            this.isEnterable = In.readBoolean();
            if (!this.isEnterable)
            {
                this.enterableDescription = In.readUTF();
                this.ticketShopCode = In.readUTF();
            }
            requestModule = In.readByte();
            return;
        }


        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }
    }
}

