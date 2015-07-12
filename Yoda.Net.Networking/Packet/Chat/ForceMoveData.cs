namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;

    public class ForceMoveData : ICommandData, IEncrypted
    {
        public ForceMoveData()
        {
        }
        public string userId;
        public bool _forceDisconnect;
        public ForceMoveData(string userId, bool forceDisconnect)
        {
            this.userId = userId;
            this._forceDisconnect = forceDisconnect;
        }

        public int packetId
        {
            get
            {
                return PacketId.FORCE_MOVE;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.userId);
            Out.writeBoolean(_forceDisconnect);
        }
    }
}

