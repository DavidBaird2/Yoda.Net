using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Packet.Chat.Casino
{
	public class CasinoGameJoinRequestData : ICommandData
	{
            public int minBet;
        public int maxBet;
        public int balance;
        public string gameCode;

        public CasinoGameJoinRequestData()
        {
         
        }

        public void readData(PiggStream In)
        {
            gameCode = In.readUTF();
            balance = In.readInt();
            minBet = In.readInt();
            maxBet = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }

        public int packetId
        {
            get
            {
                return PacketId.CASINO_GAME_JOIN_REQUEST;
            }
        }

	}
}
