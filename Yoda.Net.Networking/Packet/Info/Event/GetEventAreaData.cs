namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class GetEventAreaData : ICommandData
    {
        public string dataType;
        public string areaCode;
        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_MESSAGE_OF_AREA;
            }
        }
        public GetEventAreaData(string areaCode, string dataType)
        {
            this.areaCode = areaCode;
            this.dataType = dataType;
        }
        public void readData(PiggStream In)
        {
          areaCode = In.readUTF();
          dataType = In.readUTF();
            return;
        }
        public GetEventAreaData()
        {

        }
        public void writeData(PiggStream Out)
        {
            Out.writeUTF(areaCode);
            Out.writeUTF(dataType);
            return;
        }
    }
}

