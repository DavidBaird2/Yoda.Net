using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking
{
    public static partial class IntExtensions
    {
    
        public static void Times(this int count, Action act)
        {
            for (int i = 0; i < count; i++)
            {
                act();
            }
        }

        public static void Times(this sbyte count, Action act)
        {
            for (sbyte i = 0; i < count; i++)
            {
                act();
            }
        }
    }
}
