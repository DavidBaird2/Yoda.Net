namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;


    public class LoginResultData : ICommandData
    {
        public static sbyte HAS_PIGG_KNOWN = 0;
        public static sbyte HAS_PIGG_UNCREATE = 1;
        public static sbyte HAS_PIGG_CREATE = 2;
        public static sbyte HAS_PIGG_SWITCH = 3;
        public string amebaId;
        public int areaZoning;
        public string code;
        public int functionZoning;
        public string asUserId;
        public int gender;
        public int good;
        public bool newGift;
        public bool fortuneEnabled;
        public sbyte hasPigg;
        public sbyte realzone;
        public bool isSuccess;
        public int kitayo;
        public int mission;
        public bool newApproval;
        public bool newAsk;
        public bool newClubApproval;
        public bool newClubMessage;
        public bool newClubRequest;
        public bool newFriend;
        public bool newMessage;
        public string nickname;
        public int point;
        public bool scratchEnabled;
        public byte[] secure;
        public string ticket;
        public int tutorial;
        public int zone;
        public bool clubContribution;
        public string missionTitle;
        public bool hasNewGroupMessage;
        public sbyte liveCountDown;
        public string announceLoginKey;
        public bool isUnder15;
        public string liveName;
        public bool isShopNotification;
        public bool isBeginner;
        public bool isFirstDay;
        public bool mustReadCheck;
        public int beginnerHelpType;
        public bool acceptedSmsAuth;
        public string smsAuthUseType;
        public sbyte beginnerScratchDate;
        public int shopNoticeTypeNo;
        public string shopNoticeText;
        public double shopNoticeRemainTime;
        public bool isDiaryBan;
        public bool isDiaryBanInformed;
        public sbyte diaryActivityCount;
        public bool hasNewFriendDiaryPage;
        public int packetId
        {
            get
            {
                return 0x101;
            }
        }


        public void readData(PiggStream In)
        {
            this.isSuccess = In.readBoolean();
            this.ticket = In.readUTF();
            this.amebaId = In.readUTF();
            this.asUserId = In.readUTF();
            this.nickname = In.readUTF();
            this.code = In.readUTF();
            this.secure = In.readBytes(8);
            this.hasPigg = In.readByte();
            this.tutorial = In.readInt();
            this.point = In.readInt();
            this.good = In.readInt();
            this.kitayo = In.readInt();
            this.newApproval = In.readBoolean();
            this.newMessage = In.readBoolean();
            this.newFriend = In.readBoolean();
            this.newGift = In.readBoolean();
            this.gender = In.readByte();
            this.newClubMessage = In.readBoolean();
            this.newClubRequest = In.readBoolean();
            this.newClubApproval = In.readBoolean();
            this.clubContribution = In.readBoolean();
            this.newAsk = In.readBoolean();
            this.mission = In.readInt();
            this.missionTitle = In.readUTF();
            this.scratchEnabled = In.readBoolean();
            this.fortuneEnabled = In.readBoolean();
            var loc2 = In.readBoolean();
            this.realzone = In.readByte();
            this.functionZoning = In.readByte();
            this.areaZoning = In.readByte();
            this.hasNewGroupMessage = In.readBoolean();
            this.announceLoginKey = In.readUTF();
            this.liveCountDown = In.readByte();
            this.liveName = In.readUTF();
            this.isUnder15 = In.readBoolean();
            this.mustReadCheck = In.readBoolean();
            this.isFirstDay = In.readBoolean();
            this.isShopNotification = In.readBoolean();
            this.isBeginner = In.readBoolean();
            this.beginnerHelpType = In.readInt();
            this.acceptedSmsAuth = In.readBoolean();
            this.smsAuthUseType = In.readUTF();
            this.beginnerScratchDate = In.readByte();
            this.shopNoticeTypeNo = In.readInt();
            this.shopNoticeText = In.readUTF();
            this.shopNoticeRemainTime = In.readDouble();

            if (this.realzone == 0)
            {
                this.zone = 1;
            }
            else
            {
                this.zone = this.realzone;
            }


            this.isDiaryBan = In.readBoolean();
            this.isDiaryBanInformed = In.readBoolean();
            this.diaryActivityCount = In.readByte();
            this.hasNewFriendDiaryPage = In.readBoolean();
        }



        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }


    }
}

