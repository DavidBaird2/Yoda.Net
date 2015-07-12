namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class ChangeRoomSizeData : ICommandData
    {
        private string _authTicket;
        private string _buyType;
        private int _type;

        public ChangeRoomSizeData()
        {
        }

        public ChangeRoomSizeData(int type, string buyType, string authTicket)
        {
            this._type = type;
            this._buyType = buyType;
            this._authTicket = authTicket;
        }

        public int packetId
        {
            get
            {
                return 0x333;
            }
        }

        public void readData(PiggStream In)
        {
            this._type = In.readByte();
            this._buyType = In.readUTF();
            this._authTicket = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte) this._type);
            Out.writeUTF(this._buyType);
            Out.writeUTF(this._authTicket);
        }
    }
}

