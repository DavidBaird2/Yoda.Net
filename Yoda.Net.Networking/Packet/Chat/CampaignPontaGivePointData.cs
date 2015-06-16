using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Chat
{
	public class CampaignPontaCheckPointData :IPacket
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

        public void readData(AmebaStream In)
        {
            return;
        }

        public void writeData(AmebaStream Out)
        {
            return;
        }

	}
}
