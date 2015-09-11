namespace Yoda.Net.Networking.Packet.Info.BigEvent
{
    using System;
    using System.Collections;
    public class GetBiggEventStatusResultData : ICommandData
    {

        public GetBiggEventStatusResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_BIGG_EVENT_STATUS_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
            statusStep = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);
            Out.writeInt(statusStep);
            return;
        }



        public string code { get; set; }

        public int statusStep { get; set; }
    }
}

