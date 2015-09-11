namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;

    using Yoda.Net.Networking.Packet.Info;

    using System.Collections;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Data.Club;
    using Yoda.Net.Networking.Data.Common;

    public class GetUserProfileResultData : ICommandData
    {
        public UserProfileData data;

        public int packetId
        {
            get
            {
                return PacketId.GET_USER_PROFILE_RESULT;
            }
        }

        public void readData(PiggStream stream)
        {
            ProfileClubData clubdata = null;
            ClubEmblemData emblemdata = null;
            this.data = new UserProfileData();
            this.data.userCode = stream.readUTF();
            this.data.amebaId = stream.readUTF();
            this.data.asUserId = stream.readUTF();
            this.data.nickname = stream.readUTF();
            this.data.description = stream.readUTF();
            this.data.goodCount = stream.readInt();
            this.data.friends = stream.readInt();
            this.data.friend = stream.readBoolean();
            this.data.Ignore = stream.readBoolean();
            this.data.sameArea = stream.readBoolean();
            this.data.hasGivenGoodToday = stream.readBoolean();
            this.data.online = stream.readBoolean();
            this.data.hasFriendshipRequest = stream.readBoolean();
            this.data.sentFriendshipRequest = stream.readBoolean();
            this.data.friendshipMessage = stream.readUTF();
            this.data.isAllowedRoom = stream.readByte();
            this.data.isAllowedFriend = stream.readBoolean();
            this.data.isAllowedMail = stream.readBoolean();
            this.data.allowOpenFriendList = stream.readByte();
            this.data.isBan = stream.readBoolean();
            int totalCount = stream.readInt();
            this.data.clubDataList = new ArrayList();
            var count = 0;
            while (count < totalCount)
            {
                clubdata = new ProfileClubData();
                clubdata.clubId = stream.readUTF();
                clubdata.clubName = stream.readUTF();
                emblemdata = new ClubEmblemData();
                emblemdata.symbol = stream.readInt();
                emblemdata.Base = stream.readInt();
                emblemdata.baseColor = stream.readInt();
                emblemdata.simple = stream.readInt();
                emblemdata.simpleColor = stream.readInt();
                clubdata.emblemData = emblemdata;
                this.data.clubDataList.Add(clubdata);
                count++;
            }
            this.data.clubJoinable = stream.readBoolean();

            this.data.missionCount = stream.readInt();

            this.data.isAdmin = stream.readBoolean();
            this.data.isEvent = stream.readBoolean();
            this.data.eventTitle = stream.readUTF();
            this.data.isAndroid = stream.readBoolean();
            this.data.realzone = stream.readByte();
            this.data.isAllowGift = stream.readBoolean();
            this.data.hasPiggLife = stream.readBoolean();
            this.data.hasPiggIsland = stream.readBoolean();
            this.data.hasPiggCafe = stream.readBoolean();
            this.data.hasPiggWorld = stream.readBoolean();
            this.data.isPiggLifeAvailable = stream.readBoolean();
            this.data.isPiggIslandAvailable = stream.readBoolean();
            this.data.isPiggCafeAvailable = stream.readBoolean();
            this.data.isPiggWorldAvailable = stream.readBoolean();
            this.data.isGroupMessageEnabled = stream.readBoolean();
            this.data.oneMessage = stream.readUTF();
            this.data.beginnerRemainingCount = stream.readInt();
            if (this.data.realzone == 0)
            {
                this.data.zone = 1;
            }
            else
            {
                this.data.zone = this.data.realzone;
            }
            if (this.data.joinedContest = stream.readBoolean())
            {
                this.data.contestCode = stream.readUTF();
            }
            this.data.petType = stream.readUTF();
            this.data.petColor = stream.readInt();
            this.data.isDiaryReadEnable = stream.readBoolean();
            this.data.isNewDiaryPage = stream.readBoolean();
            this.data.totalDiaryPage = stream.readInt();
            this.data.myFavoriteCount = stream.readInt();
            this.data.receiveFavoriteCount = stream.readInt();

            this.data.isFavorite = stream.readByte();
            this.data.isAllowAddFavorite = stream.readBoolean();
            this.data.allowOpenFavoriteList = stream.readBoolean();
            this.data.isBlock = stream.readBoolean();

        }

        public void writeData(PiggStream Out)
        {

            Out.writeUTF(this.data.userCode);
            Out.writeUTF(this.data.amebaId);
            Out.writeUTF(this.data.asUserId);
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


            foreach (ProfileClubData clubdata in data.clubDataList)
            {
                Out.writeUTF(clubdata.clubId);
                Out.writeUTF(clubdata.clubName);
                ClubEmblemData emblemdata = clubdata.emblemData;
                Out.writeInt(emblemdata.symbol);
                Out.writeInt(emblemdata.Base);
                Out.writeInt(emblemdata.baseColor);
                Out.writeInt(emblemdata.simple);
                Out.writeInt(emblemdata.simpleColor);
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
            Out.writeBoolean(this.data.isPiggWorldAvailable);
            Out.writeBoolean(this.data.isGroupMessageEnabled);
            Out.writeUTF(this.data.oneMessage);

            Out.writeInt(this.data.beginnerRemainingCount);

            Out.writeBoolean(this.data.joinedContest);
            if (this.data.joinedContest)
            {
                Out.writeUTF(this.data.contestCode);
            }
            Out.writeUTF(this.data.petType);
            Out.writeInt(this.data.petColor);
            Out.writeBoolean(this.data.isDiaryReadEnable);
            Out.writeBoolean(this.data.isNewDiaryPage);
            Out.writeInt(this.data.totalDiaryPage);
            Out.writeInt(this.data.myFavoriteCount);
            Out.writeInt(this.data.receiveFavoriteCount);
            Out.writeByte(this.data.isFavorite);

            Out.writeBoolean(this.data.isAllowAddFavorite);
            Out.writeBoolean(this.data.allowOpenFavoriteList);
            Out.writeBoolean(this.data.isBlock);
        }
    }
}

