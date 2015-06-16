namespace Yoda.Net.Networking.Packet.Info.club
{
    
    using System;

    using System.Collections;
    
    using Yoda.Net.Networking.Packet.Data.club;
    using Yoda.Net.Networking.Packet.Data.common;


    public class ListClubAreaResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            ClubAreaData _loc_8 = null;
            ClubEmblemData _loc_9 = null;
            userId = In.readInt();
            var _loc_2 = In.readUTF();
            var _loc_3 = In.readUTF();
            var _loc_4 = In.readUTF();
            var _loc_5 = In.readInt();
            areaList = new ArrayList(_loc_5);
            int _loc_6 = 0;
            while (_loc_6 < _loc_5)
            {
                
                _loc_8 = new ClubAreaData();
                _loc_9 = new ClubEmblemData();
                _loc_8.nickname = _loc_2;
                _loc_8.categoryCode = In.readUTF();
                _loc_8.areaCode = In.readUTF();
                _loc_8.name = In.readUTF();
                _loc_8.description = In.readUTF();
                _loc_8.MemberCount = In.readInt();
                _loc_8.isMaster = In.readBoolean();
                _loc_8.isSubMaster = In.readBoolean();
                _loc_8.number = In.readInt();
                _loc_8.time = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                _loc_9.symbol = In.readInt();
                _loc_9.Base = In.readInt();
                _loc_9.baseColor = In.readInt();
                _loc_9.simple = In.readInt();
                _loc_9.simpleColor = In.readInt();
                _loc_8.emblemData = _loc_9;
                _loc_8.capacity = In.readInt();
                _loc_8.currentCount = In.readInt();
                _loc_8.updateTime = In.readInt();
                _loc_8.isMessageboard = In.readBoolean();
                _loc_8.contributionMinutesAgo = In.readInt();
                _loc_8.isApply = In.readBoolean();
                _loc_8.isComeNewMember = In.readBoolean();
                areaList.Insert(_loc_6 , _loc_8);
                _loc_6++;
            }
            var _loc_7 = In.readBoolean();
            return;
        }

        public void writeData(AmebaStream Out)
        {

            Out.writeInt(userId);
            Out.writeUTF("");
            Out.writeUTF("");
            Out.writeUTF("");
            Out.writeInt(areaList.Count);
            
            foreach (ClubAreaData _loc_8 in areaList)
            {
               // _loc_8.nickname = _loc_2;
                Out.writeUTF(_loc_8.categoryCode);
                Out.writeUTF(_loc_8.areaCode);
                Out.writeUTF(_loc_8.name);
                Out.writeUTF(_loc_8.description);
                Out.writeInt(_loc_8.MemberCount);
                Out.writeBoolean(_loc_8.isMaster);
                Out.writeBoolean(_loc_8.isSubMaster);
                Out.writeInt(_loc_8.number);
                Out.writeDouble(_loc_8.time.ToOADate());
                var _loc_9 = _loc_8.emblemData;

                Out.writeInt(_loc_9.symbol);
                Out.writeInt(_loc_9.Base);
                Out.writeInt(_loc_9.baseColor);
                Out.writeInt(_loc_9.simple);
                Out.writeInt(_loc_9.simpleColor);
                Out.writeInt(_loc_8.capacity);
                Out.writeInt(_loc_8.currentCount);
                Out.writeInt(_loc_8.updateTime);
                Out.writeBoolean(_loc_8.isMessageboard);
                Out.writeBoolean(_loc_8.isApply);
                Out.writeBoolean(_loc_8.isComeNewMember);
            }
            Out.writeBoolean(true);
            return;
        }
    }
}

