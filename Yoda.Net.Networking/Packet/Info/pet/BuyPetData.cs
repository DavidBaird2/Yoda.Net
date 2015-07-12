namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class BuyPetData : ICommandData
    {
        public bool confirm;
        public string areaCategory;
        public string areaCode;
        public int petId;
        public bool useCopon;
        public BuyPetData(int petId, string areaCategory, string areaCode, bool confirm,bool useCopon)
        {
            this.petId = petId;
            this.areaCategory = areaCategory;
            this.areaCode = areaCode;
            this.confirm = confirm;
            this.useCopon = useCopon;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.BUY_PET;
            }
        }
        public BuyPetData()
        {
            return;
        }
        public void readData(PiggStream In)
        {
            throw new NotImplementedException();

        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(petId);
            Out.writeUTF(areaCategory);
            Out.writeUTF(areaCode);
            Out.writeBoolean(confirm);
            Out.writeBoolean(useCopon);
            return;
        }
    }
}

