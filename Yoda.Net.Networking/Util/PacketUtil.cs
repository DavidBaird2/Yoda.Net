using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Util
{
    public class PacketUtil
    {
        public static string GetNameFromId(int id,ServerType type)
        {

            Type Command = null;
            if (type == ServerType.Chat)
            {
                Command = typeof(Yoda.Net.Networking.Packet.Chat.PacketId);
            }
            else
            {
                Command = typeof(Yoda.Net.Networking.Packet.Info.PacketId);
            }
            FieldInfo[] tes = Command.GetFields();
            bool found = false;
            foreach (FieldInfo m in tes)
            {
                int mid = (int)m.GetValue((object)Command);
                if (mid == id)
                {
                    found = true;
                   return m.Name;
                }
            }
            if (!found)
            {

                return id.ToString();
            }
            return "";
        }
    }
}
