namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    

    using System;
    using System.Collections;


    public class ListFriendshipRequestData : ICommandData
    {
        public ListFriendshipRequestData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.LIST_FRIENDSHIP_REQUEST;
            }
        }

        public void readData(PiggStream In)
        {


        }
        

        public void writeData(PiggStream Out)
        {

            
        }
    }
}

