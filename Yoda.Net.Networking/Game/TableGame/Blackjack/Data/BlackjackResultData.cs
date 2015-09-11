
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackResultData
    {
        public int cardIndex;
        public int position;
        public int balance;
        public string result;
        public int gain;

        public BlackjackResultData()
        {
            return;
        }

        public void readData(PiggStream param1)
        {
            position = param1.readByte();
            cardIndex = param1.readByte();
            gain = param1.readInt();
            balance = param1.readInt();
            result = param1.readUTF();
            return;
        }
    }
}
