
namespace Yoda.Net.Networking.Packet.Info.SnapShot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;

    public class GetSnapshotToken: ICommandData
    {
   public string token;
        public int packetId
        {
            get
            {
                return PacketId.GET_SNAPSHOT_TOKEN;
            }
        }
        public GetSnapshotToken()
        {
            return;
        }
        public void readData(PiggStream In)
        {

        }

        public void writeData(PiggStream Out)
        {

        }
    }
}

