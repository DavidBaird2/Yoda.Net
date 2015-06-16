namespace Yoda.Net.Networking.Packet.Info.footprint
{
    
    
    using System;

    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.footprint;
    public class ListFootPrintResultData : IPacket
    {
        private int _total;
        private ArrayList _footPrintList;
        public ListFootPrintResultData()
        {
            _footPrintList = new ArrayList();
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_FOOTPRINT_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {

            var _loc_2 = In.readInt();
            var _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {
                FootPrintData _loc_4 = new FootPrintData();
                _loc_4.userCode = In.readUTF();
                _loc_4.nickname = In.readUTF();
                _loc_4.amebaId = In.readUTF();
                _loc_4.date = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                _footPrintList.Add(_loc_4);
                _loc_3++;
            }
            _total = In.readInt();
            return;
        }

        public void writeData(AmebaStream Out)
        {
        }
        public ArrayList footPrintList
        {
            get
            {
                return _footPrintList;
            }
        }

    }
}

