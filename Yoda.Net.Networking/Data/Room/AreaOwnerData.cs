namespace Yoda.Net.Networking.Data.Room
{
    
    using System;

    public class AreaOwnerData
    {
        public string amebaId;
        public string userCode;
        public string asUserId;
        public string nickname;
        public bool acceptMessage;
        public bool acceptGift;
        public int zone;
        public bool hasLife;
        public bool hasIsland;
        public bool hasCafe;
        public bool hasWorld;
        public bool isGroupMessageEnabled;
        public bool hasLeftFootPrintToday;
        public int numFootPrintToday;

        public void readData(AmebaStream param1)
        {
            this.nickname = param1.readUTF();
            this.amebaId = param1.readUTF();
            this.userCode = param1.readUTF();
            this.asUserId = param1.readUTF();
            this.zone = param1.readByte();
            this.hasLeftFootPrintToday = param1.readBoolean();
            this.numFootPrintToday = param1.readInt();
            this.acceptMessage = param1.readBoolean();
            this.acceptGift = param1.readBoolean();
            this.hasLife = param1.readBoolean();
            this.hasIsland = param1.readBoolean();
            this.hasCafe = param1.readBoolean();
            this.hasWorld = param1.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.nickname);
            Out.writeUTF(this.amebaId);
            Out.writeUTF(this.userCode);
            Out.writeUTF(this.asUserId);
            Out.writeByte((byte)this.zone);
            Out.writeBoolean(this.hasLeftFootPrintToday);
            Out.writeInt(this.numFootPrintToday);
            Out.writeBoolean(this.acceptMessage);
            Out.writeBoolean(this.acceptGift);

            Out.writeBoolean(this.hasLife);
            Out.writeBoolean(this.hasIsland);
            Out.writeBoolean(this.hasCafe);
            Out.writeBoolean(this.hasWorld);
        }
    }
}

