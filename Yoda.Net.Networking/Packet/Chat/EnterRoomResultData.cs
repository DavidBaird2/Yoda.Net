namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    

    public class EnterRoomResultData : BaseEnterRoomResultData, IPacket, IEncrypted
    {
        public override int packetId
        {
            get
            {
                return 0x101;

            }
        }
    }
}

