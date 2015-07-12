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

        public void readData(PiggStream stream)
        {
            this.nickname = stream.readUTF();
            this.amebaId = stream.readUTF();
            this.userCode = stream.readUTF();
            this.asUserId = stream.readUTF();
            this.zone = stream.readByte();
            this.hasLeftFootPrintToday = stream.readBoolean();
            this.numFootPrintToday = stream.readInt();
            this.acceptMessage = stream.readBoolean();
            this.acceptGift = stream.readBoolean();
            this.hasLife = stream.readBoolean();
            this.hasIsland = stream.readBoolean();
            this.hasCafe = stream.readBoolean();
            this.hasWorld = stream.readBoolean();
        }

        public void writeData(PiggStream Out)
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

