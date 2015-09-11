namespace Yoda.Net.Networking.Packet.Info.AnalysisLog
{
    
    
    using System;


    public class ActivityLogData : ICommandData, IEncrypted, IncludeClientTime
    {

        public int subType;
        public ActivityLogData ()
        {

        }

        public int packetId
        {
            get
            {
                return PacketId.ANALYSIS_LOG;
            }
        }

        public void readData(PiggStream In)
        {
            subType = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(subType);
        }
    }
}

