using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Yoda.Net.Common;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Networking
{
    public class CommandFactory
    {

        private Dictionary<int, MethodInfo> handlers;
        private Dictionary<int, ICommandData> dataClass;
        private ServerType serverType;
        private IMessageHandler messageDelegate;

        public CommandFactory(IMessageHandler messageDelegate, ServerType type)
        {
            serverType = type;
            this.messageDelegate = messageDelegate;
            init();
        }
        private void init()
        {
            handlers = new Dictionary<int, MethodInfo>();
            dataClass = new Dictionary<int, ICommandData>();
            foreach (Type Type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (Type == null || !Type.FullName.Contains("." + Enum.GetName(typeof(ServerType), serverType) + "."))
                {
                    continue;
                }
                if (Type.GetInterfaces().Contains(typeof(ICommandData)))
                {
                    try
                    {
                        ICommandData instance = (ICommandData)Type.InvokeMember
                            (null, BindingFlags.CreateInstance, null, null, null);
                        dataClass[instance.packetId] = instance;
                    }
                    catch
                    {
                        Logger.WriteLine(LogLevel.Attention, "Error : " + Type.FullName);
                    }
                }
            }

            foreach (KeyValuePair<int, ICommandData> pair in dataClass)
            {
                ICommandData data = (ICommandData)pair.Value;
                string name = data.GetType().Name;
                foreach (MethodInfo mi in messageDelegate.GetType().GetMethods())
                {
                    ParameterInfo[] infos = mi.GetParameters();
                    foreach (ParameterInfo info in infos)
                    {
                        if (name != info.ParameterType.Name)
                        {
                            continue;
                        }
                        handlers.Add(data.packetId, mi);
                    }
                }
            }
        }
        public IMessageHandler GetMessageDelegate()
        {
            return messageDelegate;
        }

        public ICommandData getDataClass(int id)
        {
            if (dataClass.ContainsKey(id))
                return dataClass[id];
            else
                return null;
        }
        public MethodInfo getHandler(int id)
        {
            if (handlers.ContainsKey(id))
                return handlers[id];
            else
                return null;
        }
    }
}
