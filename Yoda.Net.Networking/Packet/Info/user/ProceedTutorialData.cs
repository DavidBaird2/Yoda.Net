namespace Yoda.Net.Networking.Packet.Info.User
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ProceedTutorialData : ICommandData
    {
        public ProceedTutorialData()
        {
        }
        public int step;

        public ProceedTutorialData(int step)
        {
            this.step = step;
        }
        public int packetId
        {
            get
            {
                return PacketId.PROCEED_TUTORIAL;
            }
        }

        public void readData(PiggStream In)
        {
           step= In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(step);
        }
    }
}

