namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    

    public class LoginResultData : IPacket
    {
        public static sbyte HAS_PIGG_KNOWN = 0;
        public static sbyte HAS_PIGG_UNCREATE = 1;
        public static sbyte HAS_PIGG_CREATE = 2;
        public static sbyte HAS_PIGG_SWITCH = 3;
        public string _amebaId;
        public int _areaZoning;
        public string _code;
        public int _functionZoning;
        public string _asUserId;
        public int _gender;
        public int _good;
        public bool _newGift;
        public bool _fortuneEnabled;
        public sbyte _hasPigg;
        public sbyte _realzone;
        public bool _isSuccess;
        public int _kitayo;
        public int _mission;
        public bool _newApproval;
        public bool _newAsk;
        public bool _newClubApproval;
        public bool _newClubMessage;
        public bool _newClubRequest;
        public bool _newFriend;
        public bool _newMessage;
        public string _nickname;
        public int _point;
        public bool _scratchEnabled;
        public byte[] _secure;
        public string _ticket;
        public int _tutorial;
        public int _zone;

        public int packetId
        {
            get
            {
                return 0x101;
            }
        }


        public void readData(AmebaStream param1)
        {
              this._isSuccess = param1.readBoolean();
         this._ticket = param1.readUTF();
         this._amebaId = param1.readUTF();
         this._asUserId = param1.readUTF();
         this._nickname = param1.readUTF();
         this._code = param1.readUTF();
         this._secure = param1.readBytes(8);
         this._hasPigg = param1.readByte();
         this._tutorial = param1.readInt();
         this._point = param1.readInt();
         this._good = param1.readInt();
         this._kitayo = param1.readInt();
         this._newApproval = param1.readBoolean();
         this._newMessage = param1.readBoolean();
         this._newFriend = param1.readBoolean();
         this._newGift = param1.readBoolean();
         this._gender = param1.readByte();
         this._newClubMessage = param1.readBoolean();
         this._newClubRequest = param1.readBoolean();
         this._newClubApproval = param1.readBoolean();
         this._clubContribution = param1.readBoolean();
         this._newAsk = param1.readBoolean();
         this._mission = param1.readInt();
         this._missionTitle = param1.readUTF();
         this._scratchEnabled = param1.readBoolean();
         this._fortuneEnabled = param1.readBoolean();
         var _loc2_ = param1.readBoolean();
         this._realzone = param1.readByte();
         this._functionZoning = param1.readByte();
         this._areaZoning = param1.readByte();
         this._hasNewGroupMessage = param1.readBoolean();
         this._announceLoginKey = param1.readUTF();
         this._liveCountDown = param1.readByte();
         this._liveName = param1.readUTF();
         this._isUnder15 = param1.readBoolean();
         this._mustReadCheck = param1.readBoolean();
         this._isFirstDay = param1.readBoolean();
         this._isShopNotification = param1.readBoolean();
         this._isBeginner = param1.readBoolean();
         this._beginnerHelpType = param1.readInt();
         this._acceptedSmsAuth = param1.readBoolean();
         this._smsAuthUseType = param1.readUTF();
         this._beginnerScratchDate = param1.readByte();
         this._shopNoticeTypeNo = param1.readInt();
         this._shopNoticeText = param1.readUTF();
         this._shopNoticeRemainTime = param1.readDouble();
        // this._shopNoticeText = this._shopNoticeText.replace(",","\n");
         if(this._realzone == 0)
         {
            this._zone = 1;
         }
         else
         {
            this._zone = this._realzone;
         }
       /*  if(this._realzone >= UserZoneMode.ZONE_UNDER18)
         {
            this._usePPoint = true;
         }
         else if(_loc2_)
         {
            this._usePPoint = true;
         }
         else
         {
            this._usePPoint = false;
         }*/
         
         this._isDiaryBan = param1.readBoolean();
         this._isDiaryBanInformed = param1.readBoolean();
         this._diaryActivityCount = param1.readByte();
         this._hasNewFriendDiaryPage = param1.readBoolean();
        }

        public bool scratchEnabled()
        {
            return this._scratchEnabled;
        }

        public string ticket()
        {
            return this._ticket;
        }

        public void ticket(string In)
        {
            this._ticket = In;
        }

        public int tutorial()
        {
            return this._tutorial;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeBoolean(this._isSuccess);
            Out.writeUTF(this._ticket);
            Out.writeUTF(this._amebaId);
            Out.writeUTF(this._nickname);
            Out.writeUTF(this._code);
            Out.writeBytes(this._secure);
            Out.writeByte(this._hasPigg);
            Out.writeInt(this._tutorial);
            Out.writeInt(this._point);
            Out.writeInt(this._good);
            Out.writeInt(this._kitayo);
            Out.writeBoolean(this._newApproval);
            Out.writeBoolean(this._newMessage);
            Out.writeBoolean(this._newFriend);
            Out.writeBoolean(this._newGift);
            Out.writeByte((byte) this._gender);
            Out.writeBoolean(this._newClubMessage);
            Out.writeBoolean(this._newClubRequest);
            Out.writeBoolean(this._newClubApproval);
            Out.writeBoolean(this._clubContribution);
            Out.writeBoolean(this._newAsk);
            Out.writeInt(this._mission);
            Out.writeUTF(_missionTitle);
            Out.writeBoolean(this._scratchEnabled);
            Out.writeBoolean(this._fortuneEnabled);
            Out.writeByte((byte) this._zone);
            Out.writeByte((byte) this._functionZoning);
            Out.writeByte((byte) this._areaZoning);
              Out.writeBoolean(this._hasNewGroupMessage);
             Out.writeUTF(this._announceLoginKey);
             Out.writeByte((byte)this._liveCountDown);
             Out.writeUTF(this._liveName);
              Out.writeBoolean(this._isUnder15);
              Out.writeBoolean(this._mustReadCheck);
              Out.writeBoolean(this._isFirstDay);
              Out.writeBoolean(this._isShopNotification);
              Out.writeBoolean(this._isBeginner);
        }

        public int zone()
        {
            return this._zone;
        }

        public bool _clubContribution { get; set; }

        public string _missionTitle { get; set; }

        public bool _hasNewGroupMessage { get; set; }

        public sbyte _liveCountDown { get; set; }

        public string _announceLoginKey { get; set; }

        public bool _isUnder15 { get; set; }

        public string _liveName { get; set; }

        public bool _isShopNotification { get; set; }

        public bool _isBeginner { get; set; }

        public bool _isFirstDay { get; set; }

        public bool _mustReadCheck { get; set; }

        public int _beginnerHelpType { get; set; }

        public bool _acceptedSmsAuth { get; set; }

        public string _smsAuthUseType { get; set; }

        public sbyte _beginnerScratchDate { get; set; }

        public int _shopNoticeTypeNo { get; set; }

        public string _shopNoticeText { get; set; }

        public double _shopNoticeRemainTime { get; set; }

        public bool _isDiaryBan { get; set; }

        public bool _isDiaryBanInformed { get; set; }

        public sbyte _diaryActivityCount { get; set; }

        public bool _hasNewFriendDiaryPage { get; set; }
    }
}

