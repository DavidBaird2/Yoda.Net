namespace Yoda.Net.Networking.Packet.Info.pet
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class GetPetProfileResultData : ICommandData
    {
   
 
        public GetPetProfileResultData(string usercode, int petId)
        {
  
            return;
        }

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
            return;
        }

        public void writeData(PiggStream Out)
        {
   

            return;
        }
    }
}

