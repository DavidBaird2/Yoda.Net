namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class PetTalkResultData : ICommandData
    {
        public uint color;
        public string msg;
        public int petId;

        public int packetId
        {
            get
            {
                return PacketId.PET_TALK_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.petId = In.readInt();
            this.msg = In.readUTF();
            this.color = In.readUnsignedInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.petId);
            Out.writeUTF(this.msg);
            Out.writeUnsignedInt(this.color);
        }
    }
}

