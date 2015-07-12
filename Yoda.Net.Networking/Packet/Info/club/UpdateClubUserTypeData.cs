namespace Yoda.Net.Networking.Packet.Info.club
{
    
    using System;

    using System.Collections;
    


    public class UpdateClubUserTypeData : ICommandData
    {
        public UpdateClubUserTypeData()
        {
        }
        private bool master;
        private string userId;
        private bool subMaster;
        private string areaCode;
        public UpdateClubUserTypeData(string areaCode, string userId, bool master, bool subMaster)
        {
            this.areaCode = areaCode;
            this.userId = userId;
            this.master = master;
            this.subMaster = subMaster;
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.UPDATE_CLUB_USER_TYPE;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(areaCode);
            Out.writeUTF(userId);
            Out.writeBoolean(master);
            Out.writeBoolean(subMaster);
          
        }
    }
}

