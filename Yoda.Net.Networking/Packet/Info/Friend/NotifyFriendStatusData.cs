namespace Yoda.Net.Networking.Packet.Info.Friend
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
            unsetNewMark = In.readBoolean();
          
        }
        

        public void writeData(PiggStream Out)
        {
            Out.writeBoolean(this.unsetNewMark);
            
        }

        public bool unsetNewMark { get; set; }
    }
}

