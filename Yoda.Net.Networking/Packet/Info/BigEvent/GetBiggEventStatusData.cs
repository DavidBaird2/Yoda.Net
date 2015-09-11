namespace Yoda.Net.Networking.Packet.Info.BigEvent
{
    using System;
    using System.Collections;
    public class GetBiggEventStatusData : ICommandData
    {

        public GetBiggEventStatusData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.GET_BIGG_EVENT_STATUS;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();

            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);

            return;
        }



        public string code { get; set; }
    }
}

