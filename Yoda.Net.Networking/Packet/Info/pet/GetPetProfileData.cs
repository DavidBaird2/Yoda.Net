namespace Yoda.Net.Networking.Packet.Info.pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class GetPetProfileData : ICommandData
    {

        public string usercode;

        public int petId;
        public GetPetProfileData(string usercode, int petId)
        {
            this.petId = petId;
            this.usercode = usercode;
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
        public void readData(PiggStream In)
        {
            usercode = In.readUTF();
            petId = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(usercode);
            Out.writeInt(petId);


            return;
        }
    }
}

