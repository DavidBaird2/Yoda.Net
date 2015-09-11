namespace Yoda.Net.Networking.Packet.Info.Cosme
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Data.Cosme;
    using Yoda.Net.Networking.Data.Time;

    public class ListCosmeticResultData : ICommandData
    {
        public ListCosmeticResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_COSMETIC_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.typeId = In.readByte();
            this.part = new BodyPartData();
            this.color = new BodyColorData();
            this.pos = new BodyPositionData();
            this.part.readData(In);
            this.color.readData(In);
            this.pos.readData(In);

            this.part.gender = In.readByte();
            this.serverTime = In.readTime();
            this.maxSize = In.readInt();

            int count = In.readInt();

            this.cosme = new List<CosmeItemData>();


            count.Times(() =>
            {

                var data = new CosmeItemData();
                data.readData(In);

                data.serverTime = this.serverTime;
                this.cosme.Add(data);
            });
            this.rentalExpiredItems = new List<RentalExpiredItemData>();
            count = In.readInt();
            count.Times(() =>
            {
                var reid = new RentalExpiredItemData();
                reid.uniqueId = In.readInt();
                reid.expired = In.readTime();
                rentalExpiredItems.Add(reid);

            });
            return;
        }

        public void writeData(PiggStream Out)
        {

            return;
        }


        public sbyte typeId { get; set; }

        public BodyPartData part { get; set; }

        public BodyColorData color { get; set; }

        public BodyPositionData pos { get; set; }

        public DateTime serverTime { get; set; }

        public int maxSize { get; set; }

        public List<CosmeItemData> cosme { get; set; }

        public List<RentalExpiredItemData> rentalExpiredItems { get; set; }
    }
}

