using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

using Yoda.Net.Networking.Packet.Data.common;
using Yoda.Net.Networking.Packet.Data.common.test;

namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListTravelAreaResultData : IPacket
    {
        public List<TravelAreaCategoryData> areaCategoryList;


        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_AREA_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            TravelAreaCategoryData _loc_4 = null;
            int _loc_5 = 0;
            int _loc_6 = 0;
            TravelAreaData areaData = null;
            var _loc_2 = In.readInt();
            this.areaCategoryList = new List<TravelAreaCategoryData>(_loc_2);
            int _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {

                _loc_4 = new TravelAreaCategoryData();
                _loc_4.areaCode = In.readUTF();
                _loc_4.areaName = In.readUTF();
                _loc_4.areaType = In.readInt();
                _loc_4.condtion = In.readByte();
                _loc_5 = In.readInt();

                _loc_4.list = new List<TravelAreaData>(_loc_5);
                _loc_6 = 0;
                while (_loc_6 < _loc_5)
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
                    _loc_4.list.Add(areaData);
                    _loc_6++;
                }
                this.areaCategoryList.Add(_loc_4);
                _loc_3++;
            }
            return;
        }

        public void writeData(AmebaStream Out)
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

