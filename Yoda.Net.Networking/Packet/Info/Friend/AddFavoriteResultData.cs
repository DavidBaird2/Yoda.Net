namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class AddFavoriteResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.ADD_FAVORITE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.success = In.readBoolean();
            this.targetUserCode = In.readUTF();

            if (!this.success) this.errorCode = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }




        public string errorCode { get; set; }

        public string targetUserCode { get; set; }

        public bool success { get; set; }
    }
}

