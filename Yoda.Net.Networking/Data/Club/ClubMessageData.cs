namespace Yoda.Net.Networking.Data.Club
{
    using Yoda.Net.Networking.Data.Common;
    using System;
using System.Collections;
    using System.Collections.Generic;

    public class ClubMessageData
    {
        public int status;
        public bool isMember;
        public int totalMessageNum;
        public string areaCode;
        public List<ClubMessageData> messageList;
        public  const int STATUS_WRITE = 1;
        public  const int NOW_PAGE = 1;
        public  const int STATUS_DEFAULT = 0;
        public  const int TOTAL_MESSAGE = 30;
        public  const int STATUS_DELETE = 2;

        public ClubMessageData()
        {
            messageList = new List<ClubMessageData>();
            return;
        }

    }
}

