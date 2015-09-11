using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yoda.Net.Networking.Packet;
using Yoda.Net.Networking;

namespace Yoda.Net.Networking
{
    //コマンドの検証用
    public class CommandInspector
    {

        public static void Inspect(ICommandData data)
        {
           
            int baseByteLength = 0;
            PiggStream stream = new PiggStream();
            data.writeData(stream);
            baseByteLength = (int)stream.length;

            10.Times(() =>
            {
                stream = new PiggStream();
                data.writeData(stream);

                stream.position = 0;
                stream = new PiggStream();
                data.readData(stream);
            });


            throw new CommandInspectException();
        }
    }
}
