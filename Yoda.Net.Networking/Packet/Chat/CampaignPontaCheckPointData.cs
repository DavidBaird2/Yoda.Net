using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat
{
	public class CampaignPontaGivePointData :ICommandData
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
