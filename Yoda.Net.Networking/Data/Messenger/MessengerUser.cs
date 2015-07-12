namespace Yoda.Net.Networking.Data.Messenger
{
    using System;

    public class MessengerUser
    {
        public string amebaId { get; set; }

        public object attachment { get; set; }
        public string hexCode { get; set; }
        public bool isOpenEvent{ get; set; }
        public bool isFriendListViewabled { get; set; }
        public bool isOnline { get; set; }
        public int lastLogin { get; set; }
        public string nickname { get; set; }
        public int status { get; set; }
        public string title { get; set; }

        public sbyte zone { get; set; }

        public bool needSmsAuth { get; set; }

        public bool showNewIcon { get; set; }

        public bool newFriend { get; set; }

        public string oneMessage { get; set; }

        public int recentActionOrder { get; set; }

        public bool enableDiary { get; set; }

        public bool hasNewDiaryPage { get; set; }

        public double diaryLastPostedTime { get; set; }

        public int receiveFavorites { get; set; }

        public int myFavorites { get; set; }

        public bool isFavoriteListViewabled { get; set; }

        public int friends { get; set; }
    }
}

