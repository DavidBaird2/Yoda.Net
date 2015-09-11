namespace Yoda.Net.Networking.Data.Pet
{

    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PetData
    {

        public List<PetActionData> actions { get; set; }
        public short behaviorType1;
        public short behaviorType2;
        public string character;
        public short colorId;
        public string description;
        public short gender;
        public short levelFeel;
        public short levelFriendly;
        public string name;
        public int treasuresID;
        public string treasureCode = "";
        public string owner;
        public int petId;
        public string type;
        public string category;
        public void readData(PiggStream In)
        {
            this.petId = In.readInt();
            this.type = In.readUTF();
            this.name = In.readUTF();
            this.owner = In.readUTF();
            this.treasuresID = In.readInt();
            this.treasureCode = In.readUTF();
            this.colorId = In.readByte();
            this.gender = In.readByte();
            this.levelFeel = In.readByte();
            this.levelFriendly = In.readByte();
            this.category = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(this.petId);
            Out.writeUTF(this.type);
            Out.writeUTF(this.name);
            Out.writeUTF(this.owner);
            Out.writeInt(this.treasuresID);
            Out.writeUTF(this.treasureCode);
            Out.writeByte((byte)this.colorId);
            Out.writeByte((byte)this.gender);
            Out.writeByte((byte)this.levelFeel);
            Out.writeByte((byte)this.levelFriendly);
            Out.writeUTF(category);
        }

        public string distressType { get; set; }

        public bool isTaken { get; set; }


        public int pointFriendly { get; set; }

        public bool reachedDaylyMaxPoint { get; set; }
    }

}