using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Proxy.Area
{
    public class AreaMovementManager
    {
        public List<EnterAreaQueue> queueList = new List<EnterAreaQueue>();

        public void AddAreaMovement(ProxySession session,string category,string code, string server)
        {
            var Queue = new EnterAreaQueue(session, category, code, server);
            queueList.Add(Queue);
        }

        public EnterAreaQueue Dequeue()
        {
            var target = queueList.FirstOrDefault();
            queueList.Remove(target);
            return target;
        }

 
    }


}
