using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Event
{
    public class EventData
    {
                public bool roomEventCondition;
        public string areaCategory;
        public string areaCode;
        public string areaTitle;
        public string category;
        public string title;
        public string description;
        public double createTime;
        public bool image;
        public string originPath;
        public string thumbPath;
        public int numPeople;
        public string ownerName;
        public string ownerUserCode;
        public string dataType;
        public bool warning;
        public bool prohibition = false;
        public int publishing;
        public bool likeEnabled;
        public static string NO_AMEPOINT = "event.noAmePoint";
        public static string DATA_TYPE_ROOM = "room";
        public static string DATA_TYPE_OTHERS = "othersroom";
        public static string DATA_TYPE_AREA = "area";
        public static string DATA_TYPE_COMMUNITY = "community";
        public static string DATA_TYPE_PANEL = "panel";
        public static string DATA_TYPE_FRIEND = "friend";
        public static int STATE_APPLY = 1;
        public static int STATE_OK = 2;
        public static int STATE_NG = 3;

    }
}
