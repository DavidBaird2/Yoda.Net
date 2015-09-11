namespace Yoda.Net.Networking.Packet.Info.Pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;
    using Yoda.Net.Networking.Data.Pet;

    public class BuyPetResultData : ICommandData
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
        public void readData(PiggStream In)
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

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
           
        }
    }
}

