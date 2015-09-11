namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class AddFavoriteData : ICommandData, IEncrypted, IncludeClientTime
    {

        public int packetId
        {
            get
            {
                return PacketId.ADD_FAVORITE;
            }
        }

        public void readData(PiggStream In)
        {

            targetUserCode = In.readUTF();
            isFeed = In.readBoolean();
        }


        public void writeData(PiggStream Out)
        {

            Out.writeUTF(this.targetUserCode);
            Out.writeBoolean(isFeed);
        }



        public string targetUserCode { get; set; }

        public bool isFeed { get; set; }
    }
}

