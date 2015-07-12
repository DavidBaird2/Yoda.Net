namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    
    using System;
    using System.Collections;


    public class ListFriendData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.LIST_FRIEND;
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

