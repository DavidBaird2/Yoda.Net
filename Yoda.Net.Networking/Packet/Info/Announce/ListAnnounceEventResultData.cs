using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Announce;



namespace Yoda.Net.Networking.Packet.Info.Announce
{
    public class ListAnnounceEventResultData : ICommandData
    {


        public int packetId
        {
            get
            {
                return PacketId.LIST_ANNOUNCE_EVENT_RESULT;
            }
        }

        public void readData(PiggStream In)
        {


            var count = In.readInt();
			this.list = new List<AnnounceEventData>();

            count.Times(() =>
            {
                var data = new AnnounceEventData();
                data.readData(In);

                this.list.Add( data);
            
            });

        }

        public void writeData(PiggStream Out)
        {


            return;
        }



        public List<AnnounceEventData> list { get; set; }
    }
}
