namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    using Yoda.Net.Networking.Packet.Data.common;
    
    

    public class FinishDressupResultData : IPacket
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

        public void readData(AmebaStream In)
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
        public void writeData(AmebaStream Out)
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

