using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Game.TableGame.BlackJack.Data;

namespace Yoda.Net.Networking.Game.TableGame.BlackJack
{
    public class BlackjackModel : ITableGameModel
    {

        public int userPosition { get; set; }

        public void hide()
        {

        }

        public void updateGameData(string method, PiggStream data)
        {
            Type type = typeof(BlackjackModel);
            var target = type.GetMethod(method);
            target.Invoke(this, new object[] { data });
        }


        public void showResult(PiggStream data)
        {
            BlackjackResultData d = new BlackjackResultData();
            d.readData(data);
        }
        public void removePlayer(PiggStream data)
        {
            string targetCode = data.readUTF();
        }
        public void updateBet(PiggStream data)
        {
            int postion = data.readInt();
            int bet = data.readInt();
            int chip = data.readInt();
        }

        public void onSplit(PiggStream data)
        {
            sbyte postion = data.readByte();
            int bet = data.readInt();
            int chip = data.readInt();
        }

        public void turn(PiggStream data)
        {
            sbyte postion = data.readByte();
            sbyte cardSet = data.readByte();
        }

        public void updateTableState(PiggStream data)
        {
            BlackjackTableStateData d = new BlackjackTableStateData();
            d.readData(data);
        }

        public void updateTableState2(PiggStream data, bool param2 = false)
        {
            BlackjackTableStateData d = new BlackjackTableStateData();
            d.readData(data);
        }

        public void showCasinoMinnaTeamName(PiggStream data)
        {
            string name = data.readUTF();
        }

        public void initTable(PiggStream data)
        {
            this.updateTableState2(data, true);
            this.updateTableRule(data);
            int _loc_2 = data.readInt();
            sbyte count = data.readByte();
            for (int i = 0; i < (int)count; i++)
            {
                if (data.readBoolean())
                {
                    this.addPlayer(data);
                }
            }
            this.updateDealer(data);
        }

        public void dealCard(PiggStream data)
        {
            byte[] iv = data.readBytes(8);
        }

        public void dealerFlip(PiggStream data)
        {
            sbyte _loc_2 = data.readByte();
            sbyte _loc_3 = data.readByte();
        }

        public void updatePlayerState(PiggStream data)
        {
            sbyte position = data.readByte();
            int state;
            try
            {
                state = (int)data.readByte();
            }
            catch
            {
                state = -1;
            }
        }

        public void updateTableRule(PiggStream data)
        {
            BlackjackTableRuleData d = new BlackjackTableRuleData();
            d.readData(data);
        }

        public void onLeaveGame(PiggStream data)
        {
            this.hide();
        }

        public void dealerHit(PiggStream data)
        {
            sbyte _loc_2 = data.readByte();
            sbyte _loc_3 = data.readByte();
        }

        public void resetTable(PiggStream data)
        {

        }

        public void onHit(PiggStream data)
        {
            BlackjackHitCardDate d = new BlackjackHitCardDate();
            d.readData(data);
        }

        public void feverStart(PiggStream data)
        {

        }

        public void feverEnd(PiggStream data)
        {

        }

        public void onSurrender(PiggStream data)
        {
            sbyte position = data.readByte();
        }

        public void setSelf(PiggStream data)
        {
            this.userPosition = data.readInt();
        }

        public void betStart(PiggStream data)
        {
            int maxBet = data.readInt();
            int minBet = data.readInt();
        }

        public void onDoubleDown(PiggStream data)
        {
            sbyte position = data.readByte();
            int bet = data.readInt();
            int chip = data.readInt();
        }

        public void onInsurance(PiggStream data)
        {
            sbyte position = data.readByte();
            int bet = data.readInt();
            int chip = data.readInt();
        }

        public void dealCards(PiggStream data)
        {

        }

        public void onStay(PiggStream data)
        {
            sbyte position = data.readByte();
        }

        public void updateTimeLeft(PiggStream data)
        {
            int _loc_2 = data.readInt();
            sbyte _loc_3 = data.readByte();
        }

        public void insurance(PiggStream data)
        {
        }

        public void addPlayer(PiggStream data)
        {
            BlackjackPlayerData d = new BlackjackPlayerData();
            d.readData(data);
        }

        public void updateBalance(PiggStream data)
        {
            int _loc_2 = data.readInt();
            int _loc_3 = data.readInt();
        }

        public void luckyItemUse(PiggStream data)
        {
            sbyte _loc_2 = data.readByte();
            string _loc_3 = data.readUTF();
            string _loc_4 = data.readUTF();
        }

        public void updateDealer(PiggStream data)
        {
            BlackjackInitialDealerDealData d = new BlackjackInitialDealerDealData();
            d.readData(data);
        }

        public void show()
        {

        }
       
    }
}
