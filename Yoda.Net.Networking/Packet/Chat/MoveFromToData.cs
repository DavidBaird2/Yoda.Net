namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    

    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveFromToData : IPacket, IEncrypted
    {
        public short fromSpeed;
        public short fromDir;
        public short toZ;
        public short toY;
        public short toX;
        public short fromZ;
        public short fromY;
        public short fromX;

        public MoveFromToData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.MOVE_FROM_TO;
            }
        }

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeShort(this.fromX);
            Out.writeShort(this.fromY);
            Out.writeShort(this.fromZ);
            Out.writeShort(this.toX);
            Out.writeShort(this.toY);
            Out.writeShort(this.toZ);
            Out.writeShort(this.fromDir);
            Out.writeShort(this.fromSpeed);

        }
    }

}