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
        public static object Object = new object();
        public static void Log(LogLevel level, string text)
        {
            lock (Object)
            { 
        using(    StreamWriter writer = new StreamWriter(
                "log.txt",true))
        {
            writer.WriteLine(text);
        }

        }
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
