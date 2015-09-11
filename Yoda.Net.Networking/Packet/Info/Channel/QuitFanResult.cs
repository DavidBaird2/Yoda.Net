namespace Yoda.Net.Networking.Packet.Info.Channel
{
    using System;
    using System.Collections;
    public class QuitFanResult : ICommandData
    {


        public bool isOk = false;

        public int packetId
        {
            get
            {
                return PacketId.VJ_QUITFAN_RESULT;
            }
        }
        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(isOk);
        }

        public void readData(PiggStream In)
        {
            this.isOk = In.readBoolean();
        }

    }
}
