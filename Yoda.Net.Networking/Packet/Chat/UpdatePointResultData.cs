namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;

    public class UpdatePointResultData : ICommandData
    {
   
 
        public int packetId
        {
            get
            {
                return PacketId.UPDATE_POINT_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.point = In.readInt();
            this.plusminus = In.readInt();

            if (In.readBoolean()) this.code = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(point);
            Out.writeInt(plusminus);
            if (code != "")
            {
                Out.writeBoolean(true);
                Out.writeUTF(this.code);
            }
            else
            {
                Out.writeBoolean(false);
            }
        }

        public string code { get; set; }

        public int point { get; set; }

        public int plusminus { get; set; }
    }
}

