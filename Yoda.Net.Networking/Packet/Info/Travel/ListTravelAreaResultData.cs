using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

using Yoda.Net.Networking.Data.Common;
using Yoda.Net.Networking.Data.Area;
using Yoda.Net.Networking.Data.Event;
using Yoda.Net.Networking.Data.Channel.TimeTable;

namespace Yoda.Net.Networking.Packet.Info.Travel
{
    public class ListTravelAreaResultData : ICommandData
    {
        public List<TravelAreaCategoryData> areaCategoryList;


        public List<HistoryAreaData> historyList;
        public List<EventData> eventList;
        public List<TimetablePartyData> partyList;

        public int packetId
        {
            get
            {
                return PacketId.TRAVEL_AREA_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            var areaDataCount = 0;

            int travelAreaCategoryDataCount = In.readInt();



            this.areaCategoryList = new List<TravelAreaCategoryData>(travelAreaCategoryDataCount);
            travelAreaCategoryDataCount.Times(() =>
            {
                var areaCategoryData = new TravelAreaCategoryData();
                areaCategoryData.readData(In);

                areaDataCount = In.readInt();
                areaCategoryData.list = new List<TravelAreaData>(areaDataCount);


                areaDataCount.Times(() =>
                {
                    var travelAreaData = new TravelAreaData();
                    travelAreaData.readData(In, areaCategoryData.areaCode, areaCategoryData.areaName, areaCategoryData.areaType, areaCategoryData.condition);

                    areaCategoryData.list.Add(travelAreaData);

                });

                this.areaCategoryList.Add(areaCategoryData);

            });

            areaDataCount = In.readInt();

            if (areaDataCount > 0)
            {
                this.historyList = new List<HistoryAreaData>(areaDataCount);


                areaDataCount.Times(() =>
                {
                    var historyAreaData = new HistoryAreaData();
                    historyAreaData.readData(In);

                    this.historyList.Add(historyAreaData);

                });
            }
            else
            {
                this.historyList = new List<HistoryAreaData>();
            }

            areaDataCount = In.readInt();
            this.eventList = new List<EventData>(areaDataCount);

            areaDataCount.Times(() =>
            {
                var eventData = new EventData();
                eventData.readTravelData(In);

                this.eventList.Add(eventData);

            });

            areaDataCount = In.readInt();
            this.partyList = new List<TimetablePartyData>(areaDataCount);
            areaDataCount.Times(() =>
            {
                var travelPartyData = new TimetablePartyData();
                travelPartyData.readTravelData(In);

                this.partyList.Add(travelPartyData);

            });
        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

