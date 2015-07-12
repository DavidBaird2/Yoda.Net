namespace Yoda.Net.Networking.Packet.Info.mannequin
{


    using System;
    using System.Drawing;
    using Yoda.Net.Networking.Data.Mannequin;

    public class SwapMannequinData : ICommandData, IEncrypted
    {
        public MannequinIdData mannequinId;

        public object thumbnail;
        public int packetId
        {
            get
            {
                return PacketId.SWAP_MANNEQUIN;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream stream)
        {
            this.mannequinId.writeData(stream);
            if (this.thumbnail == null)
            {
                stream.writeShort(0);
            }
            else
            {
                /* 
                  compress();
                  writeShort(length);
                  writeBytes(data);*/
            }
        }
    }
}

