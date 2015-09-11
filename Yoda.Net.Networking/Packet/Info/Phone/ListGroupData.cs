using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ListGroupData : ICommandData
	{
        public ListGroupData()
        {
        }


      
        public void writeData(PiggStream stream) 
        {
         

            return;
        }
        public void readData(PiggStream stream)
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.LIST_GROUPMESSAGE_GROUP;
            }
        }
	}
}
