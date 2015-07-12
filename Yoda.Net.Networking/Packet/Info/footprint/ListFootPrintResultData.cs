namespace Yoda.Net.Networking.Packet.Info.footprint
{
    
    
    using System;

    using System.Collections;
    using Yoda.Net.Networking.Data.Footprint;
    public class ListFootPrintResultData : ICommandData
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

        public void readData(PiggStream In)
        {

            var num = In.readInt();
            var i = 0;
            while (i < num)
            {
                FootPrintData fpd = new FootPrintData();
                fpd.userCode = In.readUTF();
                fpd.nickname = In.readUTF();
                fpd.amebaId = In.readUTF();
                fpd.date = DateTime.Parse("1970/1/1 09:00").AddMilliseconds(In.readDouble());
                _footPrintList.Add(fpd);
                i++;
            }
            _total = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
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

