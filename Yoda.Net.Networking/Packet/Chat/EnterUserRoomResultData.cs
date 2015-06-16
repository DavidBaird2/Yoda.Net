using Yoda.Net.Networking.Packet.Chat;
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Packet.Data.diary;
    using Yoda.Net.Networking.Packet.Data.pet;
    using Yoda.Net.Networking.Packet.Data.mannequin;
    using Yoda.Net.Networking.Packet.Data.room;
    

    public class EnterUserRoomResultData : BaseEnterRoomResultData ,IPacket
    {
     
        public EnterUserRoomResultData()
        {
        }

        public override　int packetId
        {
            get
            {
                return PacketId.ENTER_USER_ROOM_RESULT;
            }
        }
        public override 　string commandType
        {
            get
            {
                return AreaData.TYPE_ROOM;
            }
        }
            override protected void readCodeData(AmebaStream param1) 
        {
            areaData.frontCode = param1.readUTF();
            areaData.wallCode = param1.readUTF();
            areaData.floorCode = param1.readUTF();
            areaData.windowCode = param1.readUTF();
            areaData.groundCode = "";
            return;
        }
            override protected void writeCodeData(AmebaStream param1)
            {
                     param1.writeUTF(areaData.frontCode);
                      param1.writeUTF(areaData.wallCode );
                      param1.writeUTF(areaData.floorCode);
                      param1.writeUTF(areaData.windowCode );

                return;
            }
     
        override public void readData(AmebaStream　param1) 
        {
          int _loc_6 = 0;
            int _loc_7 = 0;
            base.readData(param1);

            var testArray = new AmebaStream();
            base.writeData(testArray);
            EnterUserRoomResultData result = new EnterUserRoomResultData();
            testArray.position = 0;
          
             //   result.readData(testArray);

            
            areaData.roomIndex = param1.readInt();
            var _loc_2 = param1.readInt();
            //areaData.users = this.Vector.<int>([-1, -1, -1, -1, -1]);
            Hashtable _loc_3 = new Hashtable();
            
            int _loc_4 = 0;
            int _loc_5 = 0;
            while (_loc_5 < _loc_2)
            {
                
                _loc_6 = param1.readInt();
                _loc_7 = param1.readInt();
                _loc_3[_loc_6.ToString()] = _loc_7.ToString();
                if (_loc_6 > _loc_4)
                {
                    _loc_4 = _loc_6;
                }
                _loc_5++;
            }
            _loc_4++;
            _loc_5 = 0;
            while (_loc_5 < _loc_4)
            {
                
                if (_loc_3[_loc_5] != null)
                {
                    areaData.users[_loc_5.ToString()] = _loc_3[_loc_5];
                }
                _loc_5++;
            }
            areaData.expansionSize = _loc_4 - 1;
               areaData.hasGarden = !(_loc_3[0] == null);
         areaData.ownerData = new AreaOwnerData();
         areaData.ownerData.readData(param1);
         areaData.hasLeftFootPrintToday = areaData.ownerData.hasLeftFootPrintToday;
         areaData.numFootPrintToday = areaData.ownerData.numFootPrintToday;
         isPiggLifeAvailable = param1.readByte();
         isPiggIslandAvailable = param1.readByte();
         isPiggCafeAvailable = param1.readByte();
         isPiggWorldAvailable = param1.readByte();
         isCheckPlaceGift = param1.readBoolean();
         areaData.ownerData.isGroupMessageEnabled = param1.readBoolean();
         areaData.canMoveGarden = param1.readBoolean();
       //  log("OneMessageUtil.ENABLE::" + OneMessageUtil.ENABLE);
        /* if(OneMessageUtil.ENABLE)
         {
            log("一言メッセージ");*/
            areaData.oneMessage = param1.readUTF();
           /* log(areaData.oneMessage);
         }*/
        var  _loc6_ = param1.readBoolean();
         if(_loc6_ == true)
         {
           var _loc10_ = param1.readUTF();
         var   _loc11_ = param1.readUTF();
        var    _loc12_ = param1.readUTF();
       var     _loc13_ = param1.readUTF();
       var     _loc14_ = param1.readDouble();
       var     _loc15_ = param1.readDouble();
        // var   _arrowEventData = new EventArrowData(_loc10_,_loc11_,_loc12_,_loc13_,_loc14_,_loc15_);
         }
         areaData.becomableFriend = param1.readBoolean();
         defaultOwnerEnterRoomNum = param1.readByte();
         defaultVisitorEnterRoomNum = param1.readByte();
         diaryRoomData = new DiaryRoomData();
         diaryRoomData.readData(param1);
         areaData.isSupportContest = isSupportContest = param1.readBoolean();
         if(isSupportContest)
         {
            areaData.contestCode = contestCode = param1.readUTF();
         }
         petSolveFurniturePlaceListData = new List<PetSolveFurniturePlaceData>();
        var  _loc2_ = param1.readInt();
       var   _loc5_ = 0;
         while(_loc5_ < _loc2_)
         {
           var  _loc16_ = new PetSolveFurniturePlaceData();
            _loc16_.furnitureId = param1.readUTF();
            _loc16_.roomIndex = param1.readInt();
            _loc16_.countSelf = param1.readInt();
            _loc16_.countOther = param1.readInt();
            _loc16_.countMax = param1.readInt();
            petSolveFurniturePlaceListData.Add(_loc16_);
            _loc5_++;
         }
         enablePetSolveFurniture = param1.readBoolean();
         allowMannequinDetail = param1.readByte();
         _loc2_ = param1.readByte();
          //    Poyon66d4.Engine.Log("<<","\n=== EnterUserRoomResultData count=" + _loc2_);
         areaMannequins = new List<MannequinData>(_loc2_);
         _loc5_ = 0;
         while(_loc5_ < _loc2_)
         {
            var _loc7_ = new MannequinData();
            _loc7_.readDataEnterRoom(param1);
            areaMannequins.Add( _loc7_);
          //  Poyon66d4.Engine.Log("<<","new MQ_ID:" + _loc7_.mannequinId);
            _loc5_++;
         }    
        }
        public override void writeData(AmebaStream param1)
        {
            base.writeData(param1);
          param1.writeInt(  areaData.roomIndex );
          param1.writeInt(areaData.users.Count);
          foreach (KeyValuePair<string, string> entry in areaData.users)
          {
              param1.writeInt(Convert.ToInt32(entry.Value));
              param1.writeInt(Convert.ToInt32(entry.Key));
          }


            areaData.ownerData = new AreaOwnerData();
            areaData.ownerData.writeData(param1);

            param1.writeByte((byte)isPiggLifeAvailable);
           param1.writeByte((byte)isPiggIslandAvailable);
             param1.writeByte((byte)isPiggCafeAvailable);
            // log(isPiggCafeAvailable);

       


             param1.writeByte( (byte)  isPiggWorldAvailable);
             param1.writeBoolean(isCheckPlaceGift );
                param1.writeBoolean( areaData.ownerData.isGroupMessageEnabled );
                param1.writeBoolean( areaData.canMoveGarden);
                param1.writeUTF(areaData.oneMessage);
                param1.writeBoolean(false);
                param1.writeBoolean(areaData.becomableFriend);
             
        }

        public sbyte defaultOwnerEnterRoomNum { get; set; }

        public sbyte defaultVisitorEnterRoomNum { get; set; }

        public DiaryRoomData diaryRoomData { get; set; }

        public bool isSupportContest { get; set; }

        public string contestCode { get; set; }

        public List<PetSolveFurniturePlaceData> petSolveFurniturePlaceListData { get; set; }

        public bool enablePetSolveFurniture { get; set; }

        public sbyte allowMannequinDetail { get; set; }

        public List<MannequinData> areaMannequins { get; set; }
    }
}

