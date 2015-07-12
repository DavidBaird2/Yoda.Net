namespace Yoda.Net.Networking.Packet.Info.shop
{


    using System;
    public class TreasureGetData : ICommandData
    {
        public TreasureGetData()
        {
        }
        private int _treasureId;
        private string _code;
        public TreasureGetData(int treasureId, string code)
        {
            _treasureId = treasureId;
            _code = code;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.TREASURE_GET;
            }
        }

        public void readData(PiggStream In)
        {

            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(_treasureId);
            Out.writeUTF(_code);
            return;
        }
    }
}

