namespace Yoda.Net.Networking.Packet.Info.User
{
    
    using System;

    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using Yoda.Net.Networking.Packet.Info;

    public class ConflictedPiggResultData : ICommandData
    {
        public int zone;
        public string nickname;
        public ConflictedPiggResultData()
        {

        }
        public int packetId
        {
            get
            {
                return PacketId.GET_CONFLICTED_PIGG_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            //ﾃｽﾄ
            Out.writeUTF("");
            Out.writeInt(2);
            Out.writeUTF("8bd3fc8193abc5a9");
            Out.writeUTF("渋谷ではたらく社長");
            Out.writeDouble(DateTime.Now.ToOADate());
            Out.writeInt(458);
            Out.writeInt(99999);
            Out.writeInt(128);
            Out.writeInt(250);
            Out.writeInt(100);
            Out.writeUTF("aa62361116ec08c8");
            Out.writeUTF("ウランディ");
            Out.writeDouble(DateTime.Now.Subtract(DateTime.Parse("1970/1/1 09:00")).TotalMilliseconds);
            Out.writeInt(454);
            Out.writeInt(178);
            Out.writeInt(451);
            Out.writeInt(457);
            Out.writeInt(197);
        }
    }
}

