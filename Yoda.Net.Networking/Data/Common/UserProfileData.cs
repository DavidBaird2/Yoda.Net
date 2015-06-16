namespace Yoda.Net.Data.Common
{
    using System;
    using System.Collections;

    public class UserProfileData
    {
        public int allowOpenFriendList;
        public string amebaId;
        public ArrayList clubDataList;
        public bool clubJoinable;
        public string description;
        public string eventTitle;
        public bool friend = false;
        public int friends;
        public string friendshipMessage;
        public int goodCount;
        public bool hasFriendshipRequest = false;
        public bool hasGivenGoodToday = false;
        public bool Ignore = false;
        public bool isAdmin;
        public bool isAllowedFriend;
        public bool isAllowedMail;
        public int isAllowedRoom;
        public bool isAndroid;
        public bool isBan;
        public bool isEvent;
        public bool isFishingProfile = true;
        public bool isFriend;
        public bool isInYourRoom;
        public int missionCount;
        public string nickname;
        public bool online = false;
        public int profileMode = 0;
        public bool sameArea = false;
        public bool sentFriendshipRequest = false;
        public string userCode;
        public int zone;
        public bool isAllowGift;
        public bool hasPiggLife;
        public bool isPiggLifeAvailable;
        public bool isPiggSurvivalGame;
        public bool isPiggIslandAvailable;
        public bool isGroupMessageEnabled;
        public bool isPiggWorldAvailable;
        public bool isPiggCafeAvailable;

        public bool hasPiggIsland { get; set; }

        public bool hasPiggCafe { get; set; }

        public bool hasPiggWorld { get; set; }
        public string oneMessage;

        public string asUserId { get; set; }

        public sbyte realzone { get; set; }

        public int beginnerRemainingCount { get; set; }

        public bool joinedContest { get; set; }

        public string contestCode { get; set; }

        public string petType { get; set; }

        public int petColor { get; set; }

        public bool isDiaryReadEnable { get; set; }

        public int totalDiaryPage { get; set; }

        public bool isNewDiaryPage { get; set; }
    }
}