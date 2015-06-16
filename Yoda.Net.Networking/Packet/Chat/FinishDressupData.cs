﻿namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    
    


    public class FinishDressupData : IPacket
    {
        public bool updated = false;

        public FinishDressupData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.FINISH_DRESSUP;
            }
        }

        public void readData(AmebaStream In)
        {
            updated = In.readBoolean();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeBoolean(updated);
        }
    }
}

