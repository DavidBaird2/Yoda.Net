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

        private Dictionary<int, MethodInfo> _handlers;
        private Dictionary<int, ICommandData> _dataClass;
        private ServerType _serverType;
        private IMessageHandler _messageDelegate;

        public CommandFactory(IMessageHandler messageDelegate, ServerType type)
        {
            _serverType = type;
            _messageDelegate = messageDelegate;
            _handlers = new Dictionary<int, MethodInfo>();
            _dataClass = new Dictionary<int, ICommandData>();
            foreach (Type Type in Assembly.GetExecutingAssembly().GetTypes())
            {
                string test = "." + Enum.GetName(typeof(ServerType), _serverType) + ".";
                if (Type == null || !Type.FullName.Contains("." + Enum.GetName(typeof(ServerType), _serverType) + "."))
                {
                    continue;
                }
                if (Type.GetInterfaces().Contains(typeof(ICommandData)))
                {
                    try
                    {
                        ICommandData instance = (ICommandData)Type.InvokeMember
                            (null, BindingFlags.CreateInstance, null, null, null);
                        _dataClass[instance.packetId] = instance;
                    }
                    catch
                    {
                        //TODO : 
                        Logger.Log(LogLevel.Attention, "Error : " + Type.FullName);
                    }


                }
            }


            foreach (KeyValuePair<int, ICommandData> pair in _dataClass)
            {
                ICommandData data = (ICommandData)pair.Value;
                string name = data.GetType().Name;
                foreach (MethodInfo mi in _messageDelegate.GetType().GetMethods())
                {
                    ParameterInfo[] infos = mi.GetParameters();
                    foreach (ParameterInfo info in infos)
                    {
                        if (infos.Length != 1 || name != info.ParameterType.Name)
                        {
                            continue;
                        }
                        _handlers.Add(data.packetId, mi);
                    }
                }
            }
        }
        public IMessageHandler GetMessageDelegate()
        {
            return _messageDelegate;
        }

        public ICommandData getDataClass(int id)
        {
            if (_dataClass.ContainsKey(id))
                return _dataClass[id];
            else
                return null;
        }
        public MethodInfo getHandler(int id)
        {
            if (_handlers.ContainsKey(id))
                return _handlers[id];
            else
                return null;
        }
    }
}
