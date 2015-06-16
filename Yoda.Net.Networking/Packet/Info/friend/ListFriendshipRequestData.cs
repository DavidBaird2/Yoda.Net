namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    

    using System;
    using System.Collections;


    public class ListFriendshipRequestData : IPacket
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

        public void readData(AmebaStream In)
        {


        }
        

        public void writeData(AmebaStream Out)
        {

            
        }
    }
}

