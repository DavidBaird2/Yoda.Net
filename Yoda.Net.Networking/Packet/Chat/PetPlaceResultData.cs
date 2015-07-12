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
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }
    }
}

