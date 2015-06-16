namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetLeaveResultData : IPacket
    {
        public int petId;

        public int packetId
        {
            get
            {
                    return PacketId.PET_LEAVE_RESULT;
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

