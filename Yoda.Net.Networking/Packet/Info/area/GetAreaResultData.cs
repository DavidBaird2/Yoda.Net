﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Area
{
    public class GetAreaResultData: IPacket
    {
        public string category;
        public string code;
        public string server;
        public GetAreaResultData()
        {

        }
        public int packetId
        {
            get
            {
                return 0x511;
            }
        }

        public void readData(AmebaStream In)
        {
            this.category = In.readUTF();
            this.code = In.readUTF();
            this.server = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this.category);
            Out.writeUTF(this.code);
            Out.writeUTF(this.server);
        }
    }
}
