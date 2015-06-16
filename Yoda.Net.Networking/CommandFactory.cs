using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Yoda.Net.Networking.Packet;

namespace Yoda.Net.Networking
{
    public class CommandFactory
    {

        private Dictionary<int, MethodInfo> _handlers;
        private Dictionary<int, IPacket> _dataClass;
        private ServerType _serverType;
        private IMessageDelegate _messageDelegate;

        public CommandFactory(IMessageDelegate messageDelegate, ServerType type)
        {
            _serverType = type;
            _messageDelegate = messageDelegate;
            _handlers = new Dictionary<int, MethodInfo>();
            _dataClass = new Dictionary<int, IPacket>();
            foreach (Type Type in Assembly.GetExecutingAssembly().GetTypes())
            {
                string test = "." + Enum.GetName(typeof(ServerType), _serverType) + ".";
                if (Type == null || !Type.FullName.Contains("." + Enum.GetName(typeof(ServerType), _serverType) + "."))
                {
                    continue;
                }
                if (Type.GetInterfaces().Contains(typeof(IPacket)))
                {
                    try
                    {
                        IPacket instance = (IPacket)Type.InvokeMember
                            (null, BindingFlags.CreateInstance, null, null, null);
                        _dataClass[instance.packetId] = instance;
                    }
                    catch
                    {
                        //TODO : 
                    }


                }
            }
            foreach (KeyValuePair<int, IPacket> pair in _dataClass)
            {
                IPacket data = (IPacket)pair.Value;
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
        public IMessageDelegate GetMessageDelegate()
        {
            return _messageDelegate;
        }

        public IPacket getDataClass(int id)
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
