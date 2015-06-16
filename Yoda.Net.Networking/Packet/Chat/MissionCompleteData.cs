namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;


    public class MissionCompleteData : IPacket
    {
        public string _code;

        public int packetId
        {
            get
            {
                return PacketId.MISSION_COMPLETE;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._code);

        }
    }
}

