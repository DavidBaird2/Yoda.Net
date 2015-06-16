using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Common
{
    public class Logger
    {
        public static void Log(LogLevel level, string text)
        {
            Console.WriteLine(text);
        }
    }
    public enum LogLevel
    {
        Infomation,
        Attention,
        Sex
    }
}
