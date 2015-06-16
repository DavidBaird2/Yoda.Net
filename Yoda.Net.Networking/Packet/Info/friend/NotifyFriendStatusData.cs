namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    
    using System;
    using System.Collections;


    public class ListFriendData : IPacket
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_FRIEND;
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

