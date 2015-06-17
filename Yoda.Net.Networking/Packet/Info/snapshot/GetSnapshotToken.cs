
namespace Yoda.Net.Networking.Packet.Info.snapshot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using System.Collections;

    public class GetSnapshotTokenResult : IPacket
    {
   public string token;
        public int packetId
        {
            get
            {
                return PacketId.GET_SNAPSHOT_TOKEN_RESULT;
            }
        }
        public GetSnapshotTokenResult()
        {
            return;
        }
        public void readData(AmebaStream In)
        {
            this.token = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {

        }
    }
}

