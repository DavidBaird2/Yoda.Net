using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Game.TableGame
{
    public interface ITableGameModel
    {
        void hide();
        void updateGameData(string method, PiggStream data);
        void show();
    }
}
