namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Room;
    public class EnterUserGardenResultData : EnterUserRoomResultData
    {

        public EnterUserGardenResultData()
        {
        }

        public override　int packetId
        {
            get
            {
                return PacketId.ENTER_USER_GARDEN_RESULT;
            }
        }
        public override string commandType
        {
            get
            {
                return AreaData.TYPE_GARDEN;
            }
        }
            override protected void readCodeData(AmebaStream param1) 
        {
            areaData.skyCode = param1.readUTF();
            areaData.houseCode = param1.readUTF();
            areaData.groundCode = param1.readUTF();
            areaData.roadCode = param1.readUTF();
            return;
        }
            override protected void writeCodeData(AmebaStream param1)
            {
                param1.writeUTF(areaData.skyCode);
                param1.writeUTF(areaData.houseCode);
                param1.writeUTF(areaData.groundCode);
                param1.writeUTF(areaData.roadCode);
        
                return;
            }
            override public void readData(AmebaStream param1) 
        {
            bool _loc_2 = false;
            var _loc_3 = "";
            base.readData(param1);
            _loc_2 = param1.readBoolean();
            if (_loc_2)
            {
                _loc_3 = param1.readUTF();
                _shuffleGoOutData = new ShuffleGoOutData(_loc_3);
            }
            return;
        }
     
    }
}

