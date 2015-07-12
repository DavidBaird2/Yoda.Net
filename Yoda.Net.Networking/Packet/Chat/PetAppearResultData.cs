namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;


    public class PetAppearResultData : ICommandData
    {
        public int petId;
        public bool owner;

  

        public int packetId
        {
            get
            {
                return PacketId.PET_APPEAR_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
                this.petId = In.readInt();
                this.owner = In.readBoolean();
            
      
        }

        public void writeData(PiggStream Out)
        {
            this.petId = Out.readInt();
            this.owner = Out.readBoolean();
        }
    }
}

