namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class ForceMoveData : IPacket, IEncrypted
    {
        public string userId;
        public bool _forceDisconnect;
        public ForceMoveData(string param1 , bool param2)
        {
            this.userId = param1;
            this._forceDisconnect = param2;
        }

        public int packetId
        {
            get
            {
                return PacketId.FORCE_MOVE;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.userId);
            Out.writeBoolean(_forceDisconnect);
        }
    }
}

