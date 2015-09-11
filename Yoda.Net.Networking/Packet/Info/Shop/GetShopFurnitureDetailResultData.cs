
namespace Yoda.Net.Networking.Packet.Info.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Yoda.Net.Networking.Data.LogicShop;
    using Yoda.Net.Networking.Data.Room;



    public class GetShopFurnitureDetailResultData : ICommandData
    {
        public GetShopFurnitureDetailResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_SHOP_FURNITURE_DETAIL_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.shopCode = In.readUTF();
            this.defineArray = new List<DefineFurniture>();
            this.appendDefineFurnitures(this.defineArray, In);
            this.appendDefineFurnitures(this.defineArray, In);
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }



        protected void appendDefineFurnitures(List<DefineFurniture> difine, PiggStream stream)
        {



            var defineNum = stream.readInt();
            defineNum.Times(() =>
            {
                var define = new DefineFurniture();
                define.characterId = stream.readUTF();
                define.category = stream.readUTF();
                define.name = stream.readUTF();
                int partNum = stream.readShort();
                var partsList = new List<PartData>();


                partNum.Times(() =>
                {
                    PartData partData = new PartData();
                    partData.readData(stream, false);

                    partsList.Add(partData);

                });

                define.parts = partsList;
                difine.Add(define);

            });

        }

        public string shopCode { get; set; }

        public List<DefineFurniture> defineArray { get; set; }
    }
}

