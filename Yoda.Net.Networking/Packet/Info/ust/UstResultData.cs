namespace Yoda.Net.Networking.Packet.Info.ust
{
    
    
    using System;

    public class UstResultData : IPacket
    {
        public UstData ustData = new UstData();

        public int packetId
        {
            get
            {
                return 0x2601;
            }
        }

        public void readData(AmebaStream In)
        {
            this.ustData = new UstData();
            this.ustData.actionCode = In.readUTF();
            this.ustData.channel = In.readUTF();
            this.ustData.name = In.readUTF();
            this.ustData.description = In.readUTF();
            this.ustData.startTime = In.readUTF();
            this.ustData.endTime = In.readUTF();
            this.ustData.isOpen = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.ustData.actionCode);
            Out.writeUTF(this.ustData.channel);
            Out.writeUTF(this.ustData.name);
            Out.writeUTF(this.ustData.description);
            Out.writeUTF(this.ustData.startTime);
            Out.writeUTF(this.ustData.endTime);
            Out.writeBoolean(this.ustData.isOpen);
        }
    }
}

