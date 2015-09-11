namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;

    public class OpenNoticeBoradeCreatePanelData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.OPEN_NOTICE_BOARD_CREATE_PANEL;
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

