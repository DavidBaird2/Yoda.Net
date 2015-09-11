using Yoda.Net.Networking.Packet.Chat;
namespace Yoda.Net.Networking.Packet.Chat
{




    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Pet;
    using Yoda.Net.Networking.Data.Diary;
    using Yoda.Net.Networking.Data.Mannequin;
    using Yoda.Net.Networking.Data.Room;
    using Yoda.Net.Networking.Data;

    public class EnterUserRoomResultData : BaseEnterRoomResultData, ICommandData
    {

        public sbyte defaultOwnerEnterRoomNum { get; set; }

        public sbyte defaultVisitorEnterRoomNum { get; set; }

        public DiaryRoomData diaryRoomData { get; set; }

        public bool isSupportContest { get; set; }

        public string contestCode { get; set; }

        public List<PetSolveFurniturePlaceData> petSolveFurniturePlaceListData { get; set; }

        public bool enablePetSolveFurniture { get; set; }

        public sbyte allowMannequinDetail { get; set; }

        public List<MannequinData> areaMannequins { get; set; }

        internal EventArrowData arrowEventData { get; set; }

        public EnterUserRoomResultData()
        {
        }

        public override int packetId
        {
            get
            {
                return PacketId.ENTER_USER_ROOM_RESULT;
            }
        }
        public override string commandType
        {
            get
            {
                return AreaData.TYPE_ROOM;
            }
        }
        override protected void readCodeData(PiggStream stream)
        {
            areaData.frontCode = stream.readUTF();
            areaData.wallCode = stream.readUTF();
            areaData.floorCode = stream.readUTF();
            areaData.windowCode = stream.readUTF();
            areaData.groundCode = "";
            return;
        }
        override protected void writeCodeData(PiggStream stream)
        {
            stream.writeUTF(areaData.frontCode);
            stream.writeUTF(areaData.wallCode);
            stream.writeUTF(areaData.floorCode);
            stream.writeUTF(areaData.windowCode);

            return;
        }

        override public void readData(PiggStream stream)
        {
            int roomIndex = 0;
            int userCount = 0;
            base.readData(stream);



            areaData.roomIndex = stream.readInt();
            var roomcount = stream.readInt();
            //areaData.users = this.Vector.<int>([-1, -1, -1, -1, -1]);
            Dictionary<int, int> roomusernum = new Dictionary<int, int>();

            int maxcount = 0;
            int i = 0;
            while (i < roomcount)
            {

                roomIndex = stream.readInt();
                userCount = stream.readInt();
                roomusernum[roomIndex] = userCount;
                if (roomIndex > maxcount)
                {
                    maxcount = roomIndex;
                }
                i++;
            }
            maxcount++;
            i = 0;
            while (i < maxcount)
            {

                if (roomusernum.ContainsKey(i))
                {
                    areaData.users[i] = (int)roomusernum[i];
                }
                i++;
            }
            areaData.expansionSize = maxcount - 1;
            areaData.hasGarden = !((roomusernum.ContainsKey(0)));
            areaData.ownerData = new AreaOwnerData();
            areaData.ownerData.readData(stream);
            areaData.hasLeftFootPrintToday = areaData.ownerData.hasLeftFootPrintToday;
            areaData.numFootPrintToday = areaData.ownerData.numFootPrintToday;
            isPiggLifeAvailable = stream.readByte();
            isPiggIslandAvailable = stream.readByte();
            isPiggCafeAvailable = stream.readByte();
            isPiggWorldAvailable = stream.readByte();
            isCheckPlaceGift = stream.readBoolean();
            areaData.ownerData.isGroupMessageEnabled = stream.readBoolean();
            areaData.canMoveGarden = stream.readBoolean();

            areaData.oneMessage = stream.readUTF();

            var isEvent = stream.readBoolean();
            if (isEvent == true)
            {
                var swfCode = stream.readUTF();
                var eventAreaMessage = stream.readUTF();
                var category = stream.readUTF();
                var subCategoryCode = stream.readUTF();
                var startTime = stream.readDouble();
                var endTime = stream.readDouble();
                arrowEventData = new EventArrowData(swfCode, eventAreaMessage, category, subCategoryCode, startTime, endTime);
            }
            areaData.becomableFriend = stream.readBoolean();
            defaultOwnerEnterRoomNum = stream.readByte();
            defaultVisitorEnterRoomNum = stream.readByte();
            diaryRoomData = new DiaryRoomData();
            diaryRoomData.readData(stream);
            areaData.isSupportContest = isSupportContest = stream.readBoolean();
            if (isSupportContest)
            {
                areaData.contestCode = contestCode = stream.readUTF();
            }
            petSolveFurniturePlaceListData = new List<PetSolveFurniturePlaceData>();
            var petslovefuruniNum = stream.readInt();
            i = 0;
            while (i < petslovefuruniNum)
            {
                var petsloveData = new PetSolveFurniturePlaceData();
                petsloveData.furnitureId = stream.readUTF();
                petsloveData.roomIndex = stream.readInt();
                petsloveData.countSelf = stream.readInt();
                petsloveData.countOther = stream.readInt();
                petsloveData.countMax = stream.readInt();
                petSolveFurniturePlaceListData.Add(petsloveData);
                i++;
            }
            enablePetSolveFurniture = stream.readBoolean();
            allowMannequinDetail = stream.readByte();
            petslovefuruniNum = stream.readByte();
     
            areaMannequins = new List<MannequinData>(petslovefuruniNum);
            i = 0;
            while (i < petslovefuruniNum)
            {
                var mannequindata = new MannequinData();
                mannequindata.readDataEnterRoom(stream);
                areaMannequins.Add(mannequindata);
                i++;
            }
        }
        public override void writeData(PiggStream stream)
        {
            base.writeData(stream);
            stream.writeInt(areaData.roomIndex);
            stream.writeInt(areaData.users.Count);
            foreach (KeyValuePair<int, int> entry in areaData.users)
            {
                stream.writeInt(Convert.ToInt32(entry.Key));
                stream.writeInt(Convert.ToInt32(entry.Value));
            }



            areaData.ownerData.writeData(stream);

            stream.writeByte((byte)isPiggLifeAvailable);
            stream.writeByte((byte)isPiggIslandAvailable);
            stream.writeByte((byte)isPiggCafeAvailable);

            stream.writeByte((byte)isPiggWorldAvailable);
            stream.writeBoolean(isCheckPlaceGift);
            stream.writeBoolean(areaData.ownerData.isGroupMessageEnabled);
            stream.writeBoolean(areaData.canMoveGarden);
            stream.writeUTF(areaData.oneMessage);

            if (arrowEventData != null)
            {
                stream.writeBoolean(true);
                stream.writeUTF(arrowEventData.swfCode);

                stream.writeUTF(arrowEventData.eventAreaMessage);


                stream.writeUTF(arrowEventData.category);

                stream.writeUTF(arrowEventData.subCategoryCode);

                stream.writeDouble(arrowEventData.startTime);
                stream.writeDouble(arrowEventData.endTime);



            }
            else
            {
                stream.writeBoolean(false);
            }

            stream.writeBoolean(areaData.becomableFriend);
            stream.writeByte(defaultOwnerEnterRoomNum);
            stream.writeByte(defaultVisitorEnterRoomNum);
            diaryRoomData.writeData(stream);
            stream.writeBoolean(isSupportContest);
            if (isSupportContest)
            {
                stream.writeUTF(areaData.contestCode);
            }

            stream.writeInt(petSolveFurniturePlaceListData.Count);
            foreach (PetSolveFurniturePlaceData data in petSolveFurniturePlaceListData)
            {
                stream.writeUTF(data.furnitureId);
                stream.writeInt(data.roomIndex);
                stream.writeInt(data.countSelf);
                stream.writeInt(data.countOther);
                stream.writeInt(data.countMax);
            }
            stream.writeBoolean(enablePetSolveFurniture);
            stream.writeByte(allowMannequinDetail);
            stream.writeByte((byte)areaMannequins.Count);
            foreach (MannequinData data in areaMannequins)
            {
                data.writeDataEnterRoom(stream);
            }
        }

    }
}