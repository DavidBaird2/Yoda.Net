namespace Yoda.Net.Networking.Packet.Info.Pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class SetPetProfileData : ICommandData
    {
        public int petId;
        public string name;
        public string description;
        public bool follow;
        public SetPetProfileData(int _petId, string _name, string _description, bool _follow)
        {
            this.petId = _petId;
            this.name = _name;
            this.description = _description;
            this.follow = _follow;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.SET_PET_PROFILE;
            }
        }
        public SetPetProfileData()
        {
            return;
        }
        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.petId);
            Out.writeUTF(this.name);
            Out.writeUTF(this.description);
            Out.writeBoolean(this.follow);

            return;
        }
    }
}

