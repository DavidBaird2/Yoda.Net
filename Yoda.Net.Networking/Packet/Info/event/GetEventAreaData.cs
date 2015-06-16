namespace Yoda.Net.Networking.Packet.Info.Event
{
    
    
    using System;
    using System.Collections;

    public class GetEventAreaData : IPacket
    {
        public string _dataType;
        public string _areaCode;
        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_MESSAGE_OF_AREA;
            }
        }
        public GetEventAreaData(string param1 , string param2)
        {
            _areaCode = param1;
            _dataType = param2;
        }
        public void readData(AmebaStream In)
        {
          _areaCode = In.readUTF();
          _dataType = In.readUTF();
            return;
        }
        public GetEventAreaData()
        {

        }
        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_areaCode);
            Out.writeUTF(_dataType);
            return;
        }
    }
}

