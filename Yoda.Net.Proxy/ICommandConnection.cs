using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Proxy
{
   public interface ICommandConnection
    {
        void SendCommand(ICommandData data);
        void SendData(byte[] data);
        void SetMessageHandler(IMessageHandler handler);
        void Close();
        void Open();
        CommandFactory GetFactory();
    }
}
