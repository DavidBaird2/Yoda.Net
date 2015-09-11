
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using Yoda.Net.Networking.Data.Common;


namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackPlayerData
    {
        public Hashtable cardSets;
        public int level;
        public int chip;
        public int state;
        public bool hit;
        public ArrayList cardSetBets;
        public string grade;
        public int bet;
        public bool split;
        public bool blackjack;
        public bool burst;
        public int insurance;
        public AvatarData avatarData;
        public string itemCode;
        public int position;
        public bool doubleDown;
        public bool surrender;
        public ArrayList results;

        public BlackjackPlayerData()
        {
            results = new ArrayList();
            cardSets = new Hashtable();
            cardSetBets = new ArrayList();
            return;
        }

        public void readData(PiggStream param1)
        {
            BlackjackInitialPlayerDealData bjData = null;
            int _loc_5 = 0;
            avatarData = new AvatarData();
            avatarData.readData(param1);
            position = param1.readByte();
            state = param1.readByte();
            chip = param1.readInt();
            bet = param1.readInt();
            insurance = param1.readInt();
            doubleDown = param1.readBoolean();
            sbyte _loc_2 = param1.readByte();
            cardSets = new Hashtable();
            cardSetBets = new ArrayList();
            int _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {

                bjData = new BlackjackInitialPlayerDealData();
                cardSets[_loc_3] = bjData;
                cardSetBets.Add(param1.readInt());
                bjData.higherHand = param1.readByte();
                bjData.lowerHand = param1.readByte();
                int ArrayCount = param1.readByte();
                bjData.cards = new ArrayList(ArrayCount);
                _loc_5 = 0;
                while (_loc_5 < ArrayCount)
                {

                    //   _loc_4.cards[_loc_5] = param1.readByte();
                    bjData.cards.Add(param1.readByte());
                    _loc_5++;
                }
                _loc_3++;
            }
            itemCode = param1.readUTF();
            grade = param1.readUTF();
            return;
        }
        public string userCode
        {
            get { return avatarData.userCode; }
        }

        public string nickname
        {
            get
            {
                return avatarData.nickname;
            }
        }
    }
}
