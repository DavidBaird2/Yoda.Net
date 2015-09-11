namespace Yoda.Net.Networking.Packet.Info.Channel
    
{
    using System;
    using System.Collections;
    public class QuitFanRequest : ICommandData
    {
   
        public QuitFanRequest()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.VJ_QUITFAN_REQUEST;
            }
        }

        public void readData(PiggStream In)
        {
            _userCode = In.readUTF();
            _targetUserCode = In.readUTF();
            _value = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this._userCode);
            Out.writeUTF(this._targetUserCode);
            Out.writeUTF(this._value);
            return;
        }

        public string _userCode { get; set; }

        public string _targetUserCode { get; set; }

        public string _value { get; set; }
    }
}

