namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetLeaveResultData : ICommandData
    {
        public int petId;

        public int packetId
        {
            get
            {
                    return PacketId.PET_LEAVE_RESULT;
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

