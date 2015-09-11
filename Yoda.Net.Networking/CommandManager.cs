using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Yoda.Net.Common;
using Yoda.Net.Networking.Encryption;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Networking
{

    public class CommandManager 
    {
        public static string PROTOCOL_WEBSOCKET = "ws";
        public static string PROTOCOL_RTMP = "rtmp";


        public const short TYPE_COMMAND = 0x10;
        public const short TYPE_ENC = 0x1f1;
        public const short TYPE_COMMAND_ENC = 17;
        public const short TYPE_ID = 0x1f0;
        public const short TYPE_PING = 0x1ff;
        public int encId;
        public int connectionId;
        private int mServerBufferSize = 0;
        public CommandManager(IMessageHandler del)
        {
         
      
        }
  
    }
}
