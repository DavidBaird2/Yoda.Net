namespace Yoda.Net.Networking.Packet.Info.Friend
{



    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Messenger;
    

    public class ListFriendResultData : ICommandData
    {
        public List<MessengerUser> friends = new List<MessengerUser>();

        public ListFriendResultData()
        {

        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_FRIEND_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            var count = In.readInt();
            friends = new List<MessengerUser>(count);
            int i = 0;


            while (i < count)
            {
                var user = new MessengerUser();
                user.hexCode = In.readUTF();
                user.amebaId = In.readUTF();
                user.nickname = In.readUTF();
                user.zone = In.readByte();
                user.isOnline = In.readBoolean();
                user.isFriendListViewabled = In.readBoolean();
    
                if (user.isOpenEvent = In.readBoolean())
                {
                    user.title = In.readUTF();
                }
                user.needSmsAuth = In.readBoolean();
                user.showNewIcon = In.readBoolean();
                user.newFriend = In.readBoolean();
                user.oneMessage = In.readUTF();

                user.recentActionOrder = In.readInt();
                user.enableDiary = In.readBoolean();
                user.hasNewDiaryPage = In.readBoolean();
                user.diaryLastPostedTime = In.readDouble();
                user.isFavoriteListViewabled = In.readBoolean();
                user.myFavorites = In.readInt();
                user.receiveFavorites = In.readInt();
                user.friends = In.readInt();
                this.friends.Add(user);
               
                i++;
            }
            this.friendRequestCondition = In.readByte();
            return;
        }

       
        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
       /*     Out.writeInt(friends.Count);
            foreach (MessengerUser user in friends)
            {
                Out.writeUTF(user.hexCode);
                Out.writeUTF(user.amebaId);
                Out.writeUTF(user.nickname);
                Out.writeByte(7);
                Out.writeBoolean(user.isOnline);
                Out.writeInt(user.lastLogin);
                Out.writeBoolean(user.isFriendListViewabled);
                Out.writeBoolean(user.isOpenEvent);
                Out.writeUTF(user.title);
            }*/
        }

        public int friendRequestCondition { get; set; }
    }
}

