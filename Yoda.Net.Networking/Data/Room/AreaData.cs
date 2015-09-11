namespace Yoda.Net.Networking.Data.Room
{

    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using Yoda.Net.Common;

    public class AreaData
    {

        public int roomIndex;
        public string categoryName;
        public string areaName;
        public string categoryCode;
        public string subCategoryCode;
        public string bundleCode;
        public string areaCode;
        public bool isPublished;
        public bool isUserRoomOwner;
        public bool hasLeftFootPrintToday;
        public int numFootPrintToday;

        public Double serverTime;
        public string wallCode;
        public string floorCode;
        public string windowCode;
        public string frontCode;
        public string houseCode;
        public string groundCode;
        public string roadCode;
        public string skyCode;
        public int sizeX;
        public int sizeY;
        public AreaOwnerData ownerData;
        public bool hasGarden;
        public int expansionSize;
        public LinkedHashMap<int, int> users = new LinkedHashMap<int, int>();
        public string areaType;
        public bool canMoveGarden;
        public string oneMessage;
        public bool becomableFriend;
        public static readonly int BASE_HOUSE_SIZE = 7;
        public static readonly string TYPE_AREA = "area";
        public static readonly string TYPE_ROOM = "room";
        public static readonly string TYPE_GARDEN = "garden";
        public static readonly string TYPE_CLUB = "club";


        public AreaData()
        {
            this.roomIndex = 1;
            this.categoryName = "";
            this.areaName = "";
            this.categoryCode = "";
            this.subCategoryCode = "";
            this.bundleCode = "";
            this.isPublished = false;
            this.areaCode = "";
            this.wallCode = "";
            this.floorCode = "";
            this.windowCode = "";
            this.frontCode = "";
            this.houseCode = "";
            this.groundCode = "";
            this.roadCode = "";
            this.skyCode = "";
            this.areaType = TYPE_AREA;
            this.expansionSize = 0;
            //  this.users = new ArrayList();
            this.sizeX = 8;
            this.sizeY = 8;
            this.ownerData = null;
            this.canMoveGarden = true;
            return;
        }

        public AreaData clone()
        {
            var areaData = new AreaData();
            areaData.categoryName = this.categoryName;
            areaData.areaName = this.areaName;
            areaData.categoryCode = this.categoryCode;
            areaData.subCategoryCode = this.subCategoryCode;
            areaData.bundleCode = this.bundleCode;
            areaData.isPublished = this.isPublished;
            areaData.areaCode = this.areaCode;
            areaData.wallCode = this.wallCode;
            areaData.floorCode = this.floorCode;
            areaData.windowCode = this.windowCode;
            areaData.frontCode = this.frontCode;
            areaData.sizeX = this.sizeX;
            areaData.sizeY = this.sizeY;
            areaData.ownerData = new AreaOwnerData();
            areaData.ownerData.acceptMessage = this.ownerData.acceptMessage;
            areaData.ownerData.nickname = this.ownerData.nickname;
            areaData.expansionSize = this.expansionSize;
            areaData.canMoveGarden = this.canMoveGarden;
            return areaData;
        }

        public bool isSupportContest { get; set; }

        public string contestCode { get; set; }

        public int zone { get; set; }

        public string gameCode { get; set; }

        public bool isMatchingArea { get; set; }

        public System.Collections.Generic.Dictionary<int, int> tags { get; set; }
    }
}

