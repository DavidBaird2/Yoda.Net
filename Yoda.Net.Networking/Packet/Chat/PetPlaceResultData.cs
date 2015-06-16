namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;
    using Yoda.Net.Networking.Packet.Data.pet;


    public class PetPlaceResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            petData = new PetData();
            petData.readData(In);
            x = In.readShort();
            y = In.readShort();
            z = In.readShort();
            dir = In.readByte();
            sleeping = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
        }
    }
}

