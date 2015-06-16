namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetTreasureProfileData : IPacket
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

        public void readData(AmebaStream In)
        {
            this.petId = In.readInt();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this.petId);
        }
    }
}

