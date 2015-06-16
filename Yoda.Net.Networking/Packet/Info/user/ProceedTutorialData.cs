namespace libPigg.net.info.user
{

    using System;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ProceedTutorialData : IPacket
    {
        private int _step;

        public ProceedTutorialData(int step)
        {
            this._step = step;
        }
        public int packetId
        {
            get
            {
                return PacketId.PROCEED_TUTORIAL;
            }
        }

        public void readData(AmebaStream In)
        {
           _step= In.readInt();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(_step);
        }
    }
}

