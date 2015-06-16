namespace Yoda.Net.Networking.Data.Room
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;

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
        public bool isAdmin;
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
        public Hashtable users = new Hashtable();
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
            var _loc_1 = new AreaData();
            _loc_1.categoryName = this.categoryName;
            _loc_1.areaName = this.areaName;
            _loc_1.categoryCode = this.categoryCode;
            _loc_1.subCategoryCode = this.subCategoryCode;
            _loc_1.bundleCode = this.bundleCode;
            _loc_1.isPublished = this.isPublished;
            _loc_1.areaCode = this.areaCode;
            _loc_1.wallCode = this.wallCode;
            _loc_1.floorCode = this.floorCode;
            _loc_1.windowCode = this.windowCode;
            _loc_1.frontCode = this.frontCode;
            _loc_1.sizeX = this.sizeX;
            _loc_1.sizeY = this.sizeY;
            _loc_1.ownerData = new AreaOwnerData();
            _loc_1.ownerData.acceptMessage = this.ownerData.acceptMessage;
            _loc_1.ownerData.nickname = this.ownerData.nickname;
            _loc_1.expansionSize = this.expansionSize;
            _loc_1.canMoveGarden = this.canMoveGarden;
            return _loc_1;
        }

        public bool isSupportContest { get; set; }

        public string contestCode { get; set; }
    }
}

