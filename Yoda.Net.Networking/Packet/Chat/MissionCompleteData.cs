namespace Yoda.Net.Networking.Packet.Chat
{
    
    
    using System;


    public class MissionCompleteData : ICommandData
    {
        public string code;

        public int packetId
        {
            get
            {
                return PacketId.MISSION_COMPLETE;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);

        }
    }
}

