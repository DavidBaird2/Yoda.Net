namespace Yoda.Net.Networking.Packet.Chat
{

    using System;
    using Yoda.Net.Networking.Data.Common;
    
    

    public class FinishDressupResultData : ICommandData
    {
        public string userCode;
        public AvatarData avatarData;

        public FinishDressupResultData()
        {
        }



        public int packetId
        {
            get
            {
                return PacketId.FINISH_DRESSUP_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            if (In.readBoolean())
            {
                avatarData = new AvatarData();
                avatarData.readData(In);
                userCode = avatarData.userCode;
            }
            else
            {
                userCode = In.readUTF();
            }
            return;
            
        }
        public void writeData(PiggStream Out)
        {
            if (avatarData == null)
            {
                Out.writeBoolean(false);
                Out.writeUTF(userCode);
            }
            else
            {
                Out.writeBoolean(true);
                avatarData.writeData(Out);
            }

        }
    }
}

