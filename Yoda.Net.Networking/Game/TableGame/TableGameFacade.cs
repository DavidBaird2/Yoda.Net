using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Game.TableGame.Baccarat;
using Yoda.Net.Networking.Game.TableGame.BlackJack;
using Yoda.Net.Networking.Game.TableGame.Roulette;
using Yoda.Net.Networking.Game.TableGame.Slot;
using Yoda.Net.Networking.Packet.Chat.Game.Data;

namespace Yoda.Net.Networking.Game.TableGame
{
    public class TableGameFacade
    {
        public ITableGameModel currentModel;
        public void show(string type)
        {

            if (type == "blackjack")
            {
                this.currentModel = new BlackjackModel();
            }
            else if (type == "slot")
            {
                this.currentModel = new SlotModel();
            }
            else if (type == "roulette")
            {
                this.currentModel = new RouletteModel();
            }
            else if (type == "baccarat")
            {
                this.currentModel = new BaccaratModel();
            }
            this.currentModel.show();
        }

        public void abort(string type)
        {
            if (type == "maintenance")
            {
                //"まもなくメンテナンスのため、ゲームを終了しました。"
            }
        }

        public void data(TableGameResultData data)
        {
            this.currentModel.updateGameData(data.method, data.data);
        }
    }
}
