using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

using Yoda.Net.Networking.Data.Common;

namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListTravelAreaResultData : ICommandData
    {
        public List<TravelAreaCategoryData> areaCategoryList;


        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_AREA_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
           

            TravelAreaData areaData = null;
            var totalCount = In.readInt();
            this.areaCategoryList = new List<TravelAreaCategoryData>();
            int n = 0;
            while (n < totalCount)
            {

               var tacd = new TravelAreaCategoryData();
                tacd.areaCode = In.readUTF();
                tacd.areaName = In.readUTF();
                tacd.areaType = In.readInt();
                tacd.condtion = In.readByte();
                var count = In.readInt();

                tacd.list = new List<TravelAreaData>(count);
              var n2 = 0;
                while (n2 < count)
                {

                    areaData = new TravelAreaData();
                    
                    areaData.code = In.readUTF();
                    areaData.bundle = In.readUTF();
                    areaData.name = In.readUTF();
                    areaData.description = In.readUTF();
                    areaData.url = In.readUTF();
                    areaData.arrowedZone = In.readByte();
                    areaData.capacity = In.readInt();
                    areaData.currentCount = In.readInt();
                    areaData.condition = In.readByte();
                    areaData.recommendNum = In.readInt();
                    areaData.isConfirmationDisabled = In.readBoolean();
                    areaData.isGlow = In.readBoolean();
                    areaData.isPiggSocialGame = In.readBoolean();
                    areaData.isChannel = In.readBoolean();
                    areaData.isShop = In.readBoolean();
                    areaData.isGame = In.readBoolean();
                    areaData.isEnterable = In.readBoolean();
                    if (areaData.isGame == true)
                    {
                        areaData.isBecomeEnterable = In.readBoolean();
                        areaData.becomeEnterableMessage = In.readUTF();
                    }
                    tacd.list.Add(areaData);
                    n2++;
                }
                this.areaCategoryList.Add(tacd);
                n++;
            }
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(areaCategoryList.Count);
            foreach (TravelAreaCategoryData categoryData in areaCategoryList)
            {


                Out.writeUTF(categoryData.areaCode);
                Out.writeUTF(categoryData.areaName);
                Out.writeInt(categoryData.areaType);
                Out.writeInt(categoryData.list.Count);
                foreach (TravelAreaData areaData in categoryData.list)
                {


                    Out.writeUTF(areaData.code);
                    Out.writeUTF(areaData.bundle);
                    Out.writeUTF(areaData.name);
                    Out.writeUTF(areaData.description);
                    Out.writeUTF(areaData.url);
                    Out.writeByte((byte)areaData.arrowedZone);
                    Out.writeInt(areaData.capacity);
                    Out.writeInt(areaData.currentCount);
                    Out.writeByte((byte)areaData.condition);
                    Out.writeInt(areaData.recommendNum);
                    Out.writeBoolean(areaData.isConfirmationDisabled);
                    Out.writeBoolean(areaData.isGlow);
                    Out.writeBoolean(areaData.isPiggSocialGame);
                    Out.writeBoolean(areaData.isChannel);
                    Out.writeBoolean(areaData.isShop);
                    Out.writeBoolean(areaData.isGame);
                    Out.writeBoolean(areaData.isEnterable);
                    if (areaData.isGame == true)
                    {
                        Out.writeBoolean(areaData.isBecomeEnterable);
                        Out.writeUTF(areaData.becomeEnterableMessage);
                    }

                }

            }
            return;
        }
    }
}

