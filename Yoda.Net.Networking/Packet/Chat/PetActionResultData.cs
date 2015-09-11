namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class PetActionResultData : ICommandData
    {

        public PetActionResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.PET_ACTION_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.petId = In.readInt();
            this.actionCode = In.readUTF();
            this.userCode = In.readUTF();
            this.miscId = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(petId);
            Out.writeUTF(this.actionCode);

            Out.writeUTF(this.userCode);
            Out.writeInt(miscId);
         
        }

        public int petId { get; set; }

        public string actionCode { get; set; }

        public string userCode { get; set; }

        public int miscId { get; set; }
    }
}

