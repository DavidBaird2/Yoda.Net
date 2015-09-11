using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Packet
{
    public interface ICommandData
    {
        int packetId
        {
            get;
        }
        void readData(PiggStream stream);
        void writeData(PiggStream stream);
    }
}
