using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking
{
    public class Header
    {
        public int callId;
        public short packetId;
        public int length;
        public short type;
        public void read(AmebaStream array)
        {
            type = array.readShort();
            packetId = array.readShort();
            length = array.readInt();
            callId = array.readInt();
        }
        public void write(AmebaStream array)
        {
            array.writeShort(type);
            array.writeShort(packetId);
            array.writeInt(length);
            array.writeInt(callId);
        }
    }
}
