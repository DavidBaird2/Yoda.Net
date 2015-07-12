namespace Yoda.Net.Networking.Packet.Info.maintenance
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;

    public class MaintenanceScheduleResult : ICommandData
    {
        public bool enable;
        public int left;
        public string name;
        public string url;

        public int packetId
        {
            get
            {
                return 0x92;
            }
        }

        public void readData(PiggStream In)
        {
            this.enable = In.readBoolean();
            if (this.enable)
            {
                this.name = In.readUTF();
                this.url = In.readUTF();
                this.left = In.readInt();
            }
        }

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(this.enable);
            if (this.enable)
            {
                Out.writeUTF(this.name);
                Out.writeUTF(this.url);
                Out.writeInt(this.left);
            }
        }
    }
}

