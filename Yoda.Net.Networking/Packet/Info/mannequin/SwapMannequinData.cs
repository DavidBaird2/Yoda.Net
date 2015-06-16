namespace Yoda.Net.Networking.Packet.Info.mannequin
{
    using Yoda.Net.Networking.Packet.Data.mannequin;


    using System;
    using System.Drawing;

    public class SwapMannequinData : IPacket, IEncrypted
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

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream param1)
        {
            AmebaStream _loc2_ = null;
            this.mannequinId.writeData(param1);
            if (this.thumbnail == null)
            {
                param1.writeShort(0);
            }
            else
            {
                /*  _loc2_ = this.thumbnail.getPixels(new Rectangle(0,0,this.thumbnail.width,this.thumbnail.height));
                  _loc2_.compress();
                  param1.writeShort(_loc2_.length);
                  param1.writeBytes(_loc2_);*/
            }
        }
    }
}

