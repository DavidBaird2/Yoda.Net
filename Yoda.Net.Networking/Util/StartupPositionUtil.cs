using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Yoda.Net.Networking.Packet.Chat;

namespace Yoda.Net.Networking.Util
{
    public class StartupPositionUtil
    {
        public static string[] getAval(BaseEnterRoomResultData data)
        {
            return getActionCode(data).Split('.');
        }

        private static string getActionCode(BaseEnterRoomResultData area)
        {
            string result = null;
            var data = Regex.Split(area.defineFurnitures.Where(i=>i.characterId== area.areaData.floorCode).Single().actionCode, "__");
            if (data.Count() != 3 || area.areaData.sizeX == 8 && area.areaData.sizeY == 8)
            {
                result = data[0];
            }
            else if (area.areaData.sizeX == 12 && area.areaData.sizeY == 12)
            {
                result = data[1];
            }
            else if (area.areaData.sizeX == 16 && area.areaData.sizeY == 16)
            {
                result = data[2];
            }
            else
            {
                result = data[0];
            }
            return result;
        }

    }
}
