namespace Yoda.Net.Networking.Data.Room
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DefineFurniture : DefineData
    {
        public List<PartData> parts = new List<PartData>();
        public int sizeX = 1;
        public int sizeY = 1;
        public string category;
        public int type;
        public string description;
        public string actionCode;

        public void clean()
        {
            this.category = null;
            this.description = null;
            this.actionCode = null;
        }

        public DefineFurniture clone()
        {
            return new DefineFurniture { characterId = base.characterId, name = base.name, parts = this.parts, sizeX = this.sizeX, sizeY = this.sizeY, category = this.category, description = this.description, actionCode = this.actionCode };
        }
    }
}

