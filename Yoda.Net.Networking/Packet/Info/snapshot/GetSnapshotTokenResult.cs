
namespace Yoda.Net.Networking.Packet.Info.snapshot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using Yoda.Net.Networking.Packet.Data.common;
    using System.Collections;

    public class GetSnapshotToken: IPacket
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
        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {

        }
    }
}

