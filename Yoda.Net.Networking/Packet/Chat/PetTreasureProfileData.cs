namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetTreasureProfileData : ICommandData
    {
        public int petId;
        public PetTreasureProfileData(int id)
        {
            this.petId = id;
        }
        public PetTreasureProfileData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.PET_TREASURE_PROFILE;
            }
        }

        public void readData(PiggStream In)
        {
            this.petId = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.petId);
        }
    }
}

