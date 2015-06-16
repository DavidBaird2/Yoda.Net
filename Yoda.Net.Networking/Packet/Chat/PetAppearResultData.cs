namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;


    public class PetAppearResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            try
            {
                this.petId = In.readInt();
                this.owner = In.readBoolean();
            }
            catch(Exception e)
            {
            }
        }

        public void writeData(AmebaStream Out)
        {
            this.petId = Out.readInt();
            this.owner = Out.readBoolean();
        }
    }
}

