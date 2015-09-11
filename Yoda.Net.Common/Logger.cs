using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Common
{
    public class Logger
    {
        public static bool OutputConsole = false;
        private static object syncObject = new object();
        public static void WriteLine(LogLevel level, string text)
        {
            lock (syncObject)
            {
                using (StreamWriter writer = new StreamWriter(
                        "log.txt", true))
                {
                    writer.WriteLine(text);
                }

            }
            if(!OutputConsole)
            Console.WriteLine(text);
        }
    }
    public enum LogLevel
    {
        Infomation,
        Attention,
        AnalSex
    }
}
