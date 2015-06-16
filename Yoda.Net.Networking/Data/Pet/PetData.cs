namespace Yoda.Net.Networking.Data.Pet
{
    
    using System;
    using System.Collections;

    public class PetData
    {
        public ArrayList actions = new ArrayList();
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
        public void readData(AmebaStream In)
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

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(this.petId);
            Out.writeUTF(this.type);
            Out.writeUTF(this.name);
            Out.writeUTF(this.owner);
            Out.writeInt(this.treasuresID);
            Out.writeUTF(this.treasureCode);
            Out.writeByte((byte) this.colorId);
            Out.writeByte((byte) this.gender);
            Out.writeByte((byte) this.levelFeel);
            Out.writeByte((byte) this.levelFriendly);
            Out.writeUTF(category);
        }
    }
}

