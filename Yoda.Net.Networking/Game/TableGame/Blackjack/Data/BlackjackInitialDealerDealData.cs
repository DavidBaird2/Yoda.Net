
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackInitialDealerDealData
    {
        public int dealerType;
        public int cardTotal;
        public ArrayList cards;

        public BlackjackInitialDealerDealData()
        {
            cards = new ArrayList();
            return;
        }

        public void readData(PiggStream param1)
        {
            PiggStream data = param1;
            sbyte len = data.readByte();
            cards = new ArrayList();
            int i = 0;
            while (i < len)
            {

                cards.Add(data.readByte());
                i = (i + 1);
            }
            try
            {
                // dealerType = int(StaticVariables.getVariable("blackjack"));
                throw new Exception();
            }
            catch
            {
                dealerType = 0;
            }
            return;
        }
    }
}
