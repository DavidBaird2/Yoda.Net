using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class CampaignPontaGivePointData :IPacket
	{
        public CampaignPontaGivePointData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.CAMPAIGN_PONTA_GIVE_POINT;
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
