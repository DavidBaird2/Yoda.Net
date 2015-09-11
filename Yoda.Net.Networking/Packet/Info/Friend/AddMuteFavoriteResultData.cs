namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class AddMuteFavoriteResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.ADD_MUTE_FAVORITE_RESULT;
            }
        }


        public void readData(PiggStream In)
        {

            targetUserCode = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {

            Out.writeUTF(this.targetUserCode);
        }




        public string targetUserCode { get; set; }
    }
}

