namespace Yoda.Net.Networking.Packet.Chat
{
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;
    using System;
	public class UserEffectResultData :ICommandData 
	{
        public string userCode;
        public string effectCode;
        public UserEffectResultData(string userCode ,string effectCode)
        {
            this.userCode = userCode;
            this.effectCode = effectCode;
            return;
        }
        public UserEffectResultData()
        {
            return;
        }


        public int packetId
        {
            get
            {
                return PacketId.USER_EFFECT_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            userCode = In.readUTF();
            effectCode = In.readUTF();

        }

        public void writeData(PiggStream Out)
        {
           Out.writeUTF(userCode);
           Out.writeUTF(effectCode);
        }

	}
}
