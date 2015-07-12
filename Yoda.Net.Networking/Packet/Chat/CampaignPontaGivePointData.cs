using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Chat
{
	public class CampaignPontaCheckPointData :ICommandData
	{
        public CampaignPontaCheckPointData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.CAMPAIGN_PONTA_CHECK_POINT;
            }
        }

        public void readData(PiggStream In)
        {
            return;
        }

        public void writeData(PiggStream Out)
        {
            return;
        }

	}
}
