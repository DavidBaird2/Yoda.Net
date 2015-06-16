namespace libPigg.net.info.user
{
    
    using System;
    
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking.Packet.Data.club;
    using Yoda.Net.Networking.Packet.Data.common;
    using System.Collections;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;

    public class GetUserProfileResultData : IPacket
    {
        public UserProfileData data;

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_PROFILE_RESULT;
            }
        }

        public void readData(AmebaStream param1)
        {
            ProfileClubData _loc4_ = null;
            ClubEmblemData _loc5_ = null;
            this.data = new UserProfileData();
            this.data.userCode = param1.readUTF();
            this.data.amebaId = param1.readUTF();
            this.data.asUserId = param1.readUTF();
            this.data.nickname = param1.readUTF();
            this.data.description = param1.readUTF();
            this.data.goodCount = param1.readInt();
            this.data.friends = param1.readInt();
            this.data.friend = param1.readBoolean();
            this.data.Ignore = param1.readBoolean();
            this.data.sameArea = param1.readBoolean();
            this.data.hasGivenGoodToday = param1.readBoolean();
            this.data.online = param1.readBoolean();
            this.data.hasFriendshipRequest = param1.readBoolean();
            this.data.sentFriendshipRequest = param1.readBoolean();
            // log("\ndata.hasFriendshipRequest::" + this.data.hasFriendshipRequest);
            // log("\ndata.sentFriendshipRequest::" + this.data.sentFriendshipRequest);
            this.data.friendshipMessage = param1.readUTF();
            this.data.isAllowedRoom = param1.readByte();
            this.data.isAllowedFriend = param1.readBoolean();
            this.data.isAllowedMail = param1.readBoolean();
            this.data.allowOpenFriendList = param1.readByte();
            this.data.isBan = param1.readBoolean();
            int _loc2_ = param1.readInt();
            this.data.clubDataList = new ArrayList();
            var _loc3_ = 0;
            while (_loc3_ < _loc2_)
            {
                _loc4_ = new ProfileClubData();
                _loc4_.clubId = param1.readUTF();
                _loc4_.clubName = param1.readUTF();
                _loc5_ = new ClubEmblemData();
                _loc5_.symbol = param1.readInt();
                _loc5_.Base = param1.readInt();
                _loc5_.baseColor = param1.readInt();
                _loc5_.simple = param1.readInt();
                _loc5_.simpleColor = param1.readInt();
                _loc4_.emblemData = _loc5_;
                this.data.clubDataList.Add(_loc4_);
                _loc3_++;
            }
            this.data.clubJoinable = param1.readBoolean();
            this.data.missionCount = param1.readInt();
            this.data.isAdmin = param1.readBoolean();
            this.data.isEvent = param1.readBoolean();
            this.data.eventTitle = param1.readUTF();
            this.data.isAndroid = param1.readBoolean();
            this.data.realzone = param1.readByte();
            this.data.isAllowGift = param1.readBoolean();
            this.data.hasPiggLife = param1.readBoolean();
            this.data.hasPiggIsland = param1.readBoolean();
            this.data.hasPiggCafe = param1.readBoolean();
            this.data.hasPiggWorld = param1.readBoolean();
            this.data.isPiggLifeAvailable = param1.readBoolean();
            this.data.isPiggIslandAvailable = param1.readBoolean();
            this.data.isPiggCafeAvailable = param1.readBoolean();
            this.data.isPiggWorldAvailable = param1.readBoolean();
            this.data.isGroupMessageEnabled = param1.readBoolean();
            //  //if(OneMessageUtil.ENABLE)
          //  {
                this.data.oneMessage = param1.readUTF();
                //     }
                this.data.beginnerRemainingCount = param1.readInt();
                if (this.data.realzone == 0)
                {
                    this.data.zone = 1;
                }
                else
                {
                    this.data.zone = this.data.realzone;
                }
                if (this.data.joinedContest = param1.readBoolean())
                {
                    this.data.contestCode = param1.readUTF();
                }
                this.data.petType = param1.readUTF();
                this.data.petColor = param1.readInt();
                this.data.isDiaryReadEnable = param1.readBoolean();
                this.data.isNewDiaryPage = param1.readBoolean();
                this.data.totalDiaryPage = param1.readInt();
          //  }
        }

        public void writeData(AmebaStream Out)
        {

            Out.writeUTF(this.data.userCode);
            Out.writeUTF(this.data.amebaId);
            Out.writeUTF(this.data.nickname);
            Out.writeUTF(this.data.description);
            Out.writeInt(this.data.goodCount);
            Out.writeInt(this.data.friends);
            Out.writeBoolean(this.data.friend);
            Out.writeBoolean(this.data.Ignore);
            Out.writeBoolean(this.data.sameArea);
            Out.writeBoolean(this.data.hasGivenGoodToday);
            Out.writeBoolean(this.data.online);
            Out.writeBoolean(this.data.hasFriendshipRequest);
            Out.writeBoolean(this.data.sentFriendshipRequest);
            Out.writeUTF(this.data.friendshipMessage);
            Out.writeByte((byte)this.data.isAllowedRoom);
            Out.writeBoolean(this.data.isAllowedFriend);
            Out.writeBoolean(this.data.isAllowedMail);
            Out.writeByte((byte)this.data.allowOpenFriendList);
            Out.writeBoolean(this.data.isBan);
            Out.writeInt(this.data.clubDataList.Count);


            foreach (ProfileClubData _loc_4 in data.clubDataList)
            {
                Out.writeUTF(_loc_4.clubId);
                Out.writeUTF(_loc_4.clubName);
                ClubEmblemData _loc_5 = _loc_4.emblemData;
                Out.writeInt(_loc_5.symbol);
                Out.writeInt(_loc_5.Base);
                Out.writeInt(_loc_5.baseColor);
                Out.writeInt(_loc_5.simple);
                Out.writeInt(_loc_5.simpleColor);
            }


            Out.writeBoolean(this.data.clubJoinable);
            Out.writeInt(this.data.missionCount);
            Out.writeBoolean(this.data.isAdmin);
            Out.writeBoolean(this.data.isEvent);
            Out.writeUTF(this.data.eventTitle);
            Out.writeBoolean(this.data.isAndroid);
            Out.writeByte((byte)this.data.zone);
            Out.writeBoolean(this.data.isAllowGift);
            Out.writeBoolean(this.data.hasPiggLife);
               Out.writeBoolean(this.data.hasPiggIsland);
               Out.writeBoolean(this.data.hasPiggCafe);
               Out.writeBoolean(this.data.hasPiggWorld);
            Out.writeBoolean(this.data.isPiggLifeAvailable);
            Out.writeBoolean(this.data.isPiggSurvivalGame);
            Out.writeBoolean(this.data.isPiggIslandAvailable);
            Out.writeBoolean( this.data.isPiggWorldAvailable);
            Out.writeBoolean(this.data.isGroupMessageEnabled);
            Out.writeUTF(this.data.oneMessage);
        }
    }
}

