
using System;
namespace Yoda.Net.Networking.Game.TableGame.BlackJack.Data
{
    public class BlackjackTableStateData
    {
        private int state;

        public string Event
        {
            get
            {
                string _loc_ = null;
                switch (this.state)
                {
                    case 0:
                        _loc_ = "待機中";
                        break;
                    case 1:
                        _loc_ = "準備完了";
                        break;
                    case 2:
                        _loc_ = "ベット中";
                        break;
                    case 3:
                        _loc_ = "ディールカード";
                        break;
                    case 4:
                        _loc_ = "インシュランスタイム";
                        break;
                    case 5:
                        _loc_ = "プレイヤーターン";
                        break;
                    case 6:
                        _loc_ = "ディーラーターン";
                        break;
                }
                return _loc_;
            }
        }
        public void readData(PiggStream param1)
        {
            this.state = (int)param1.readByte();
        }
    }
}
