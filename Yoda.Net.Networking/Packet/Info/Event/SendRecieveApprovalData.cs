namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;

    public class SendRecieveApprovalData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.SEND_RECEIVED_APPROVAL;
            }
        }

        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {

            return;
        }
    }
}

