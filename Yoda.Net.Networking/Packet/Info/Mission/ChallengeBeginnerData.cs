
namespace Yoda.Net.Networking.Packet.Info.Mission
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    

    public class ChallengeBeginnerData : ICommandData
    {
        public ChallengeBeginnerData()
        {
        }
     
        public int packetId
        {
            get
            {
                return PacketId.CHALLENGE_BEGINNER;
            }
        }

        public void readData(PiggStream In)
        {
            this.loginCount = In.readInt();
            this.isFirstLoginOfDay = In.readBoolean();
            this.beginnerBorder = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
        }

        public int beginnerBorder { get; set; }

        public bool isFirstLoginOfDay { get; set; }

        public int loginCount { get; set; }
    }
}

