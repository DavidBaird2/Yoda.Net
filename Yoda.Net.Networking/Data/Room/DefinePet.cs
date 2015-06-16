namespace Yoda.Net.Networking.Data.Room
{
    using Yoda.Net.Networking.Data.Pet;
    using System;

    public class DefinePet
    {
        public PetData data = new PetData();

        public int petId()
        {
            return this.data.petId;
        }
    }
}

