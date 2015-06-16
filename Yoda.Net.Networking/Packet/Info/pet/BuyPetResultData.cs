namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;
    using Yoda.Net.Networking.Packet.Data.pet;

    public class BuyPetResultData : IPacket
    {
        public bool confirm;
        public bool insufficient;
        public PetData data;
        public string name;
        public int resultPrice;
        public int resultPoint;



        public int packetId
        {
            get
            {
                return PacketId.BUY_PET_RESULT;
            }
        }
        public BuyPetResultData()
        {
            return;
        }
        public void readData(AmebaStream In)
        {
            data = new PetData();
            data.petId = In.readInt();
            data.name = In.readUTF();
            data.type = In.readUTF();
            data.colorId = In.readByte();
            resultPrice = In.readInt();
            resultPoint = In.readInt();
            confirm = In.readBoolean();
            insufficient = In.readBoolean();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            return;
        }
    }
}

