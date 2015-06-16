namespace Yoda.Net.Networking.Packet.Info.pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class SetPetProfileData : IPacket
    {
        public int _petId;
        public string _name;
        public string _description;
        public bool _follow;
        public SetPetProfileData(int _petId, string _name, string _description, bool _follow)
        {
            this._petId = _petId;
            this._name = _name;
            this._description = _description;
            this._follow = _follow;
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
        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this._petId);
            Out.writeUTF(this._name);
            Out.writeUTF(this._description);
            Out.writeBoolean(this._follow);

            return;
        }
    }
}

