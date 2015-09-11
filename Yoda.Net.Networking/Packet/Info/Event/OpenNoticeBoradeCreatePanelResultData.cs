namespace Yoda.Net.Networking.Packet.Info.Event
{


    using System;
    using System.Collections;

    public class OpenNoticeBoradeCreatePanelResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.OPEN_NOTICE_BOARD_CREATE_PANEL_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.defaultEnterRoomNum = In.readByte();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(defaultEnterRoomNum);
            return;
        }

        public sbyte defaultEnterRoomNum { get; set; }
    }
}

