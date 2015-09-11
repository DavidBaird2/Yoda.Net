namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;
    using Yoda.Net.Networking.Data.Pet;


    public class PetPlaceResultData : ICommandData
    {
        public PetData petData;
        public bool sleeping;
        public int dir;
        public int x;
        public int y;
        public int z;

        public int packetId
        {
            get
            {
                return PacketId.PET_PLACE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            petData = new PetData();
            petData.readData(In);
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
            dir = In.readByte();
            sleeping = In.readBoolean();
            petData.distressType = In.readUTF();
            petData.isTaken = In.readBoolean();
        }

        public void writeData(PiggStream Out)
        {
            petData.writeData(Out);
            Out.writeShort((short)x);
            Out.writeShort((short)y);
            Out.writeShort((short)z);
            Out.writeByte((byte)dir);
            Out.writeBoolean(sleeping);
           Out.writeUTF( this.petData.distressType);
         Out.writeBoolean(   this.petData.isTaken );
        }
    }
}

