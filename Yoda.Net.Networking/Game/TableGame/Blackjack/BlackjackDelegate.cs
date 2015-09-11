using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Yoda.Net.Networking;
using Yoda.Net.Networking.Game.TableGame.BlackJack.Data;

namespace Yoda.Net.Networking.Game.TableGame.BlackJack
{
    public class BlackjackDelegate
    {
            private bool isRequest = true;

        public BlackjackDelegate()
        {
            return;
        }

        public void onSplit(int param1)
        {
         
            if (!isRequest)
            {
                return;
            }
            var _loc_2 = new PiggStream();
            _loc_2.writeByte((sbyte)param1);
            _loc_2.position = 0;
            return;
        }



        public void doubleDown(int param1, int wait)
        {
   
            if (!isRequest)
            {
                return;
            }
            var _loc_2 = new PiggStream();
            _loc_2.writeByte((sbyte)param1);
            _loc_2.position = 0;
        //    session.ChatClient.sendTableGameData("doubleDown", _loc_2,wait);
      
            return;
        }


        public void onHitDone(int param1, int param2, int param3)
        {
        //    _model.onHitDone(param1, param2, param3);
            return;
        }

        public void onRequestMoreChip()
        {
          //  session.ChatClient.sendTableGameData("requestMoreChip", null);
            return;
        }


        public void hit(int param1, int wait)
        {
      
            var _loc_2 = new PiggStream();
            _loc_2.writeByte((sbyte)param1);
            _loc_2.position = 0;
       
         //   session.ChatClient.sendTableGameData("hit", _loc_2,wait);
            return;
        }

        public void onBetDone(int wait)
        {

      //      session.ChatClient.sendTableGameData("betDone", null, wait);
            return;
        }

        public void onSuspend()
        {
         /*   Engine.Log("BlackjackDelegate::onSuspend");
            _delegate.onSuspend();
            return;*/
        }

        public void stay(int param1, int wait)
        {

            if (!isRequest)
            {
                return;
            }
            var _loc_2 = new PiggStream();
            _loc_2.writeByte((sbyte)param1);
            _loc_2.position = 0;
          
     //       session.ChatClient.sendTableGameData("stay", _loc_2,wait);
            return;
        }

        public void onCutinComplete(string param1)
        {
          /*  Engine.Log("BlackjackDelegate::onCutinComplete", param1);
            _model.onCutinComplete();*/
            return;
        }

        public void ready()
        {
           // _model.isPlayer = true;
            //session.ChatClient.sendTableGameData("ready", null);
            return;
        }

        public void surrender(int param1, int wait) 
        {

            if (!isRequest)
            {
                return;
            }
            var _loc_2 = new PiggStream();
            _loc_2.writeByte((sbyte)param1);
            _loc_2.position = 0;
    
          //  session.ChatClient.sendTableGameData("surrender", _loc_2, wait);
            return;
        }

        public void openShop()
        {
          //  _delegate.openShop();
            return;
        }

        public void checkCasinoShortTermChallengeIncentive()
        {
            return;
        }

        public void onResume()
        {
         //   _delegate.onResume();
            return;
        }


        public void dealCardAt(BlackjackHitCardDate param1)
        {
 
         //   _model.excuteDealCards(param1);
            return;
        }
   
        public void doAction(int param1, string param2,int wait)
        {
      //      Engine.Log("BlackjackDelegate::doAction");
            var _loc_3 = new PiggStream();
            _loc_3.writeByte((sbyte)param1);
            _loc_3.writeUTF(param2);
            _loc_3.position = 0;
       //     session.ChatClient.sendTableGameAction(param2, wait);
         //   _delegate.onAction(param2);
            return;
        }

        public void onBet(int param1, int wait)
        {
       /*
            var _loc_2 = _model.selfPlayerData;
            var _loc_3 = _model.rule;
            if (_loc_2 == null || _loc_3 == null)
            {
                return;
            }
            if (_loc_2.bet + param1 > _loc_3.maxBet || _loc_2.chip - param1 < 0)
            {
                return;
            }
            var _loc_4 = new PiggStream();
            _loc_4.writeInt(param1);
            _loc_4.position = 0;
            //session.ChatClient.sendTableGameData("bet", _loc_4,wait);*/
            return;
        }

        public void onEnter(string param1,uint param2)
        {
           /*  Engine.Log("BlackjackDelegate::onEnter");
            _delegate.onEnter(param1, param2);*/
            return;
        }

        public void onInsurance(int param1, bool param2, int wait)
        {

            var _loc_3 = new PiggStream();
            _loc_3.writeBoolean(param2);
            _loc_3.writeByte((sbyte)param1);
            _loc_3.position = 0;
        //    session.ChatClient.sendTableGameData("insurance", _loc_3, wait);
            //_model.hideDecition();
            return;
        }

        public void checkCasinoLuckyItemList(string param1)
        {
        /*    if (_model.isPlayer)
            {
                _delegate.checkCasinoLuckyItemList(param1);
            }
            return;*/
        }

        public void checkCasinoCumulativeIncentive()
        {
          //  Executor.executeAfter(3, _delegate.checkCasinoCumulativeIncentive);
            return;
        }

    }
}
