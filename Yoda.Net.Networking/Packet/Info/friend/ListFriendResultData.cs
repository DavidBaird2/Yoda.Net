namespace Yoda.Net.Networking.Packet.Info.friend
{



    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Messenger;
    

    public class ListFriendResultData : IPacket
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

        public void readData(AmebaStream In)
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
                user.lastLogin = In.readInt();
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
                this.friends.Add(user);
               
                i++;
            }
            this.userAge = In.readInt();
            return;
        }

       
        public void writeData(AmebaStream Out)
        {
            Out.writeInt(friends.Count);
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
            }
        }

        public int userAge { get; set; }
    }
}

