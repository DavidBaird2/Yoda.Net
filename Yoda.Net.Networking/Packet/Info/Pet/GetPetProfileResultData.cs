namespace Yoda.Net.Networking.Packet.Info.Pet
{


    using System.Collections;
    using System;

    using Yoda.Net.Networking.Data.Pet;
    using System.Collections.Generic;

    public class GetPetProfileResultData : ICommandData
    {




        public int packetId
        {
            get
            {
                return PacketId.GET_PET_PROFILE_RESULT;
            }
        }
        public GetPetProfileResultData()
        {
            return;
        }
        public void readData(PiggStream In)
        {

            PetData petData = new PetData();
            petData.petId = In.readInt();
            petData.type = In.readUTF();
            petData.name = In.readUTF();
            this.profileData = new PetProfileData();
            this.profileData.description = In.readUTF();
            petData.owner = In.readUTF();
            petData.treasuresID = In.readInt();
            petData.treasureCode = In.readUTF();
            petData.gender = In.readByte();
            petData.colorId = In.readByte();
            petData.levelFeel = In.readByte();
            petData.levelFriendly = In.readShort();
            petData.behaviorType1 = In.readByte();
            petData.behaviorType2 = In.readByte();
            this.profileData.isTaken = In.readBoolean();
            this.profileData.petData = petData;
            petData.actions = new List<PetActionData>();

            var count = In.readByte();
            int i = 0;
            count.Times(() =>
            {
                var actionData = new PetActionData();
                actionData.actionCode = In.readUTF();
                actionData.actionName = In.readUTF();
                actionData.order = i;
                petData.actions.Add(actionData);
                i++;
            });
            petData.pointFriendly = In.readInt();
            petData.reachedDaylyMaxPoint = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {


            return;
        }

        public PetProfileData profileData { get; set; }
    }
}

