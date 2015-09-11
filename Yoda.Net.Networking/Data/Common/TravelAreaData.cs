namespace Yoda.Net.Networking.Data.Common
{
    using System;
    using System.Collections.Generic;

    public class TravelAreaData
    {

        public static int CONDITION_LIMIT = -1;                 
        public static int CONDITION_NEW = 1;                    
        public static int CONDITION_COMING = 2;                  
        public static int CONDITION_ACCESS = 3;                 



        public int areaType = 0;
        public string categoryCode = "";
        public string subCategoryCode = "";
        public string areaCode = "";
        public string bundleCode = "";
        public string categoryName = "";
        public string name = "";
        public string description = "";
        public string url = "";
        public int allowedZone;
        public int capacity;
        public int currentCount;
        public int condition = 0;
        public int bannerOrder = -1;
        public int recommendNum = -1;
        public string hotAreaTag = "";
        public bool isConfirmationDisabled;
        public bool isPickup;
        public bool isPiggSocialGame;
        public bool isGame;
        public bool isEnterable;
        public bool isAutoDispatch;
        public bool isTopAutoDispatch;
        public bool isSpeakArea;
        public List<sbyte> tags;
        public bool isFavorite;
        public bool isMatchingArea;
        public string matchingAreaCode;
        public bool isBigEventLock;
        public string lockToAreaCode;
        public bool isExeceptionArea;
        public List<TravelAreaData> combineArea;

        public bool isBecomeEnterable;
        public string becomeEnterableMessage = "";

        public void readData(PiggStream In, string categoryCode, string categoryName, int areaType, int condition)
        {	
            this.categoryCode = categoryCode;
            this.categoryName = categoryName;
            this.subCategoryCode = In.readUTF();
            this.bundleCode = In.readUTF();
            categoryCode = In.readUTF();
            this.name = In.readUTF();
            this.description = In.readUTF();
            this.url = In.readUTF();
            this.allowedZone = (In.readByte() + 1);
            this.capacity = In.readInt();
            this.currentCount = In.readInt();
            condition = In.readByte();//TODO

            if (condition != 0) this.condition = condition;

            this.recommendNum = In.readInt();
            this.bannerOrder = In.readInt();
            this.isConfirmationDisabled = In.readBoolean();
            this.isPickup = In.readBoolean();
            this.isPiggSocialGame = In.readBoolean();
            this.isGame = In.readBoolean();
            this.isEnterable = In.readBoolean();
            this.isAutoDispatch = In.readBoolean();

            if (this.isGame == true)
            {
                this.isBecomeEnterable = In.readBoolean();
                this.becomeEnterableMessage = In.readUTF();
            }

            this.hotAreaTag = In.readUTF();
            this.isTopAutoDispatch = In.readBoolean();

            var count = In.readInt();

            this.tags = new List<sbyte>();

             count.Times(()=>{
            
                this.tags.Add( In.readByte());
              
            });

            if (this.isMatchingArea = In.readBoolean()) this.matchingAreaCode = In.readUTF();

            this.isBigEventLock = false;
            this.isExeceptionArea = false;
            this.combineArea = null;

            if (this.categoryCode.IndexOf("commustreet") >= 0)
            {
                this.isSpeakArea = true;
            }
            else
            {
                this.isSpeakArea = false;
            }
        }



    }
}


