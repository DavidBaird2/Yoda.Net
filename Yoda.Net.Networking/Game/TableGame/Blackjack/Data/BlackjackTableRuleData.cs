
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackTableRuleData
    {
        public int deck;
        public int maxBet;
        public int minBet;

        public BlackjackTableRuleData()
        {
            return;
        }

        public void readData(PiggStream param1)
        {
            minBet = param1.readInt();
            maxBet = param1.readInt();
            deck = param1.readInt();
            return;
        }
    }
}
