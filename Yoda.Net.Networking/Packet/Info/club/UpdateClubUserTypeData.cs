namespace Yoda.Net.Networking.Packet.Info.club
{
    
    using System;

    using System.Collections;
    
    using Yoda.Net.Networking.Packet.Data.club;
    using Yoda.Net.Networking.Packet.Data.common;


    public class UpdateClubUserTypeData : IPacket
    {
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

        public void readData(AmebaStream In)
        {

        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(areaCode);
            Out.writeUTF(userId);
            Out.writeBoolean(master);
            Out.writeBoolean(subMaster);
          
        }
    }
}

