namespace Yoda.Net.Networking.Packet.Info.Club
{

    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Club;
    using Yoda.Net.Networking.Data.Common;


    public class ListClubAreaResultData : ICommandData
    {
        public ArrayList areaList;
        public int userId;

        public int packetId
        {
            get
            {
                return PacketId.LIST_CLUB_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            ClubAreaData areaData = null;
            ClubEmblemData emblemData = null;
            userId = In.readInt();
            var nickname = In.readUTF();
            var amebaId = In.readUTF();
            var usercode = In.readUTF();
            var clubCount = In.readInt();
            areaList = new ArrayList(clubCount);
            int i = 0;
            while (i < clubCount)
            {
                
                areaData = new ClubAreaData();
                emblemData = new ClubEmblemData();
                areaData.nickname = nickname;
                areaData.categoryCode = In.readUTF();
                areaData.areaCode = In.readUTF();
                areaData.name = In.readUTF();
                areaData.description = In.readUTF();
                areaData.MemberCount = In.readInt();
                areaData.isMaster = In.readBoolean();
                areaData.isSubMaster = In.readBoolean();
                areaData.number = In.readInt();
                areaData.time = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                emblemData.symbol = In.readInt();
                emblemData.Base = In.readInt();
                emblemData.baseColor = In.readInt();
                emblemData.simple = In.readInt();
                emblemData.simpleColor = In.readInt();
                areaData.emblemData = emblemData;
                areaData.capacity = In.readInt();
                areaData.currentCount = In.readInt();
                areaData.updateTime = In.readInt();
                areaData.isMessageboard = In.readBoolean();
                areaData.contributionMinutesAgo = In.readInt();
                areaData.isApply = In.readBoolean();
                areaData.isComeNewMember = In.readBoolean();
                areaList.Insert(i , areaData);
                i++;
            }
            var n = In.readBoolean();
            return;
        }

        public void writeData(PiggStream Out)
        {

            Out.writeInt(userId);
            Out.writeUTF("");
            Out.writeUTF("");
            Out.writeUTF("");
            Out.writeInt(areaList.Count);
            
            foreach (ClubAreaData clubareadata in areaList)
            {
                Out.writeUTF(clubareadata.categoryCode);
                Out.writeUTF(clubareadata.areaCode);
                Out.writeUTF(clubareadata.name);
                Out.writeUTF(clubareadata.description);
                Out.writeInt(clubareadata.MemberCount);
                Out.writeBoolean(clubareadata.isMaster);
                Out.writeBoolean(clubareadata.isSubMaster);
                Out.writeInt(clubareadata.number);
                Out.writeDouble(clubareadata.time.ToOADate());
                var emblemdata = clubareadata.emblemData;

                Out.writeInt(emblemdata.symbol);
                Out.writeInt(emblemdata.Base);
                Out.writeInt(emblemdata.baseColor);
                Out.writeInt(emblemdata.simple);
                Out.writeInt(emblemdata.simpleColor);
                Out.writeInt(clubareadata.capacity);
                Out.writeInt(clubareadata.currentCount);
                Out.writeInt(clubareadata.updateTime);
                Out.writeBoolean(clubareadata.isMessageboard);
                Out.writeBoolean(clubareadata.isApply);
                Out.writeBoolean(clubareadata.isComeNewMember);
            }
            Out.writeBoolean(true);
            return;
        }
    }
}

