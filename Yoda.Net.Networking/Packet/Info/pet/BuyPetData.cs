namespace Yoda.Net.Networking.Packet.Info.item
{
    
    
    using Yoda.Net.Networking.Packet.Info;
    using System.Collections;
    using System;

    public class BuyPetData : IPacket
    {
        private bool _confirm;
        private string _areaCategory;
        private string _areaCode;
        private int _petId;
        private bool _useCopon;
        public BuyPetData(int param1, string param2, string param3, bool param4,bool useCopon)
        {
            _petId = param1;
            _areaCategory = param2;
            _areaCode = param3;
            _confirm = param4;
            _useCopon = useCopon;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.BUY_PET;
            }
        }
        public BuyPetData()
        {
            return;
        }
        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(_petId);
            Out.writeUTF(_areaCategory);
            Out.writeUTF(_areaCode);
            Out.writeBoolean(_confirm);
            Out.writeBoolean(_useCopon);
            return;
        }
    }
}

