
using Yoda.Net.Networking.Data.Room;
namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    
    

    public class EnterAreaResultData : BaseEnterRoomResultData
    {
        public int type;
        public string code;

        public EnterAreaResultData()
        {
        }

        public override int packetId
        {
            get
            {
                return PacketId.ENTER_AREA_RESULT;
            }
        }

            override public string commandType
        {
            get
            {
                return AreaData.TYPE_AREA;
            }
        }

        override public void readData(AmebaStream　param1) 
        {
            base.readData(param1);
            return;
            areaGameId = param1.readByte();
            var _loc_2 = param1.readInt();
              this.areaGameData= new byte[0];
            if (_loc_2 != 0)
            {
                this.areaGameData = param1.readBytes(_loc_2);
            //   param1.position = param1.position + _loc_2;
            }
            isPiggDomeOpen = param1.readBoolean();
            switch(areaData.categoryCode)
            {
                case "user":
                case "club":
                case "secret":
                {
                    break;
                }
                default:
                {
                    areaData.isPublished = param1.readBoolean();
                    areaData.subCategoryCode = param1.readUTF();
                    if (areaData.subCategoryCode == "casino_royale")
                    {
                        areaData.isPublished = false;
                    }
                    areaData.bundleCode = param1.readUTF();
                    break;
       
                }
            }
            return;
        }
        public override void writeData(AmebaStream Out)
        {
            base.writeData(Out);
            Out.writeByte((byte)areaGameId);
            Out.writeInt((int)areaGameData.Length);
            if (areaGameData.Length != 0)
            {
                Out.writeBytes(new AmebaStream(areaGameData), 0, (int)areaGameData.Length);
            }
            Out.writeBoolean(isPiggDomeOpen);
            switch (areaData.categoryCode)
            {
                case "user":
                case "club":
                case "secret":
                    {
                        break;
                    }
                default:
                    {
                        Out.writeBoolean(areaData.isPublished);
                        Out.writeUTF(areaData.subCategoryCode);

                        Out.writeUTF(areaData.bundleCode);

                        break;
                    }
            }
            Out.writeBoolean(false);
        }
    }
}

