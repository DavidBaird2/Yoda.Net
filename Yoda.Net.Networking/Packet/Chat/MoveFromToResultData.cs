namespace Yoda.Net.Networking.Packet.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    

    
    using Yoda.Net.Networking.Packet.Chat;

    public class MoveFromToResultData : ICommandData
    {
        public short fromSpeed { get; set; }
        public short fromDir { get; set; }
        public short toZ { get; set; }
        public short toY { get; set; }
        public short toX { get; set; }
        public short fromZ { get; set; }
        public short fromY { get; set; }
        public short fromX { get; set; }
        public string code { get; set; }
        public MoveFromToResultData()
        {
        }
        public int packetId
        {
            get
            {
                return PacketId.MOVE_FROM_TO_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            code = In.readUTFBytes(16);
            fromX = In.readShort();
            fromY = In.readShort();
            fromZ = In.readShort();
            toX = In.readShort();
            toY = In.readShort();
            toZ = In.readShort();
            fromDir = In.readShort();
            fromSpeed = In.readShort();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTFBytes(code);
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