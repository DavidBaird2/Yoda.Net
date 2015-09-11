
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackHitCardDate
    {
        public int card;
        public int cardSet;
        public int lower;
        public int position;
        public int higher;

        public BlackjackHitCardDate()
        {
            return;
        }

        public void readData(PiggStream In)
        {
            position = In.readByte();
            cardSet = In.readByte();
            card = In.readByte();
            lower = In.readByte();
            higher = In.readByte();
            return;
        }
    }
}
