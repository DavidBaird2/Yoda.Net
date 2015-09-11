using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Data.Phone;



namespace Yoda.Net.Networking.Packet.Info.Phone
{
    public class ConfirmGroupMessageAlert : ICommandData
	{
        public ConfirmGroupMessageAlert()
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
                return PacketId.CONFIRM_GROUPMESSAGE_ALERT;
            }
        }
	}
}
