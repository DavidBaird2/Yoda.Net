namespace Yoda.Net.Networking.Packet.Info.pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class GetPetProfileData : IPacket
    {

        public string _usercode;

        public int _petId;
        public GetPetProfileData(string usercode, int petId)
        {
            _petId = petId;
            _usercode = usercode;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_PET_PROFILE;
            }
        }
        public GetPetProfileData()
        {
            return;
        }
        public void readData(AmebaStream In)
        {
            _usercode = In.readUTF();
            _petId = In.readInt();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_usercode);
            Out.writeInt(_petId);


            return;
        }
    }
}

