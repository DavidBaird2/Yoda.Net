using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Data.Room;
using Yoda.Net.Networking.Packet.Chat;
using Yoda.Net.Server.Chat;
using Yoda.Net.Server.Models;

namespace Yoda.Net.Server.Chat
{
    public class ChatMessageHandler : IMessageHandler
    {
        public ChatServer server;
        public ChatMessageHandler(ChatServer server)
        {
            this.server = server;
        }
        public void onLogin(LoginChatData data, RemortClient client)
        {
           var targetClient = YodaServer.GetInfo().GetClinet(data.secure);
           client.infoClient = targetClient;
           client.user = targetClient.user;
            if(targetClient != null)
            {
                LoginChatResultData result = new LoginChatResultData();
                result.serverType = 0;
                result.success = true;
                client.manager.SendCommand(result);
            }
            else
            {
                client.manager.SendCommand(new ErrorData() { message = "ログインできませんでした" });
            }
        }
        public AreaOwnerData createAreaOwnerData(RemortClient client)
        {
            AreaOwnerData owner = new AreaOwnerData();
            owner.acceptGift = false;
            owner.acceptMessage = false;
            owner.amebaId = "";
            owner.asUserId = client.user.UserId.ToString(); ;
            owner.hasCafe = false;
            owner.hasIsland = false;
            owner.hasLeftFootPrintToday = false;
            owner.hasLife = false;
            owner.hasWorld = false;
            owner.isGroupMessageEnabled = false;
            owner.nickname = client.user.NickName;
            owner.numFootPrintToday = 0;
            owner.userCode = client.user.HexCode;
            owner.zone = 0;
            return owner;
        }
        public DefineAvatar createDefineAvatar(RemortClient client)
        {
            DefineAvatar avatar = new DefineAvatar();
            avatar.characterId = client.user.HexCode;
            avatar.friend = false;
            avatar.name = client.user.NickName;
            avatar.data = new Networking.Data.Common.AvatarData();
            avatar.data.amebaId = "";
            avatar.data.asUserId = client.user.UserId.ToString();
            avatar.data.color = client.user.GetColor();
            avatar.data.cosme = new List<Networking.Data.Cosme.CosmeDressUpItemData>();
            avatar.data.position = client.user.GetPosition();
            avatar.data.userCode = client.user.HexCode;
            avatar.data.item = client.user.GetItem();
            avatar.data.part = client.user.GetParts();
            return avatar;
        }
        public DefineFurniture DeserializeDefineFuruniture(string code)
        {
            string targetDirectory = @"define\" + code.Substring(0, 2) + "\\";
            string fileName = targetDirectory + code + ".xml";
            var serializer = new XmlSerializer(typeof(DefineFurniture), new Type[1] { typeof(PartData) });
            using (var sr = new StreamReader(fileName))
            {
                return (DefineFurniture)serializer.Deserialize(sr);
            }
        }
        public List<DefineFurniture> createDefineFuruniture(BaseEnterRoomResultData target)
        {
            var list = new List<DefineFurniture>();

            if (target.areaData.floorCode != "")
            {
                list.Add(DeserializeDefineFuruniture(target.areaData.floorCode));
            }
            if (target.areaData.windowCode != "")
            {
                list.Add(DeserializeDefineFuruniture(target.areaData.windowCode));
            }
            if (target.areaData.wallCode != "")
            {
                list.Add(DeserializeDefineFuruniture(target.areaData.wallCode));
            }
            if (target.areaData.floorCode != "")
            {
                list.Add(DeserializeDefineFuruniture(target.areaData.floorCode));
            }
            if (target.areaData.groundCode != "")
            {
                list.Add(DeserializeDefineFuruniture(target.areaData.groundCode));
            }
            return list;
        }
        public void onEnterRoom(EnterRoomData data,RemortClient client)
        {
            EnterUserRoomResultData result = new EnterUserRoomResultData();
            result.areaData = new AreaData();
            result.areaData.areaCode = client.user.HexCode;
            result.areaData.areaName = client.user.NickName + "のお部屋";
            result.areaData.windowCode = "small_basic_window";
            result.areaData.wallCode = "small_basic_wall";
            result.areaData.users = new Common.LinkedHashMap<int, int>();
            result.areaData.subCategoryCode = "";
            result.areaData.skyCode = "";
       
            result.areaData.sizeY = 8;
            result.areaData.sizeY = 8;
            result.areaData.serverTime = 0;
            result.areaData.roomIndex = 0;
            result.areaData.roadCode = "";
            result.areaData.ownerData = createAreaOwnerData(client);
            result.areaData.oneMessage = "";
            result.areaData.numFootPrintToday = 0;
            result.areaData.isUserRoomOwner = true;
            result.areaData.isSupportContest = false;
            result.areaData.isPublished = false;
            result.areaData.houseCode = "";
            result.areaData.hasLeftFootPrintToday = false;
            result.areaData.hasGarden = false;
            result.areaData.groundCode = "";
            result.areaData.floorCode = "small_basic_floor";
            result.areaData.expansionSize = 1;
            result.areaData.categoryName = "";
            result.areaData.categoryCode = "user";
            result.areaData.canMoveGarden = true;
            result.areaData.becomableFriend = false;
            result.allowMannequinDetail = 0;
            result.areaMannequins = new List<Networking.Data.Mannequin.MannequinData>();
            result.areaGameId = 0;
            result.contestCode = "";
            result.defaultOwnerEnterRoomNum = 0;
            result.defaultVisitorEnterRoomNum = 0;
            result.defineAvatars = new List<DefineAvatar>();
            result.defineAvatars.Add(createDefineAvatar(client));
            result.defineFurnitures = createDefineFuruniture(result);
            result.definePets = new List<DefinePet>();
            result.diaryRoomData = new Networking.Data.Diary.DiaryRoomData();
            result.diaryRoomData.isDiaryIconShow = false;
            result.diaryRoomData.isDiaryNewPage = false;
            result.diaryRoomData.isDiaryReadEnable = false;
            result.enablePetSolveFurniture = false;
            result.isAdmin = 0;
            result.isAllowRoomChange = true;
            result.isChannelActor = false;
            result.isCheckPlaceGift = false;
            result.isPiggCafeAvailable = 0;
            result.isPiggDomeOpen = false;
            result.isPiggIslandAvailable = 0;
            result.isPiggLifeAvailable = 0;
            result.isPiggSurvivalGameAvailable = 0;
            result.isPiggWorldAvailable = 0;
            result.isRefleshedCosmeItem = false;
            result.isSupportContest = false;
            result.placeActionItems = new List<PlaceActionItem>();
            result.placeAvatars = new List<PlaceAvatar>();
            PlaceAvatar avatar = new PlaceAvatar();
            avatar.characterId = client.user.HexCode;
            avatar.direction = 0;
            avatar.mode = 0;
            avatar.status = 0;
            avatar.tired = 0;
            avatar.x = 0;
            avatar.y = 0;
            avatar.z = 0;
            result.placeAvatars.Add(avatar);
            result.placeFurnitures = new List<PlaceFurniture>();
            result.placePets = new List<PlacePet>();
            result.serverTime = 1;
            result.shuffleGoOutData = new ShuffleGoOutData("zzzzzzzzzzzzzzzz");
            result.petSolveFurniturePlaceListData = new List<Networking.Data.Pet.PetSolveFurniturePlaceData>();
            client.manager.SendCommand(result);
        }
    }
}
