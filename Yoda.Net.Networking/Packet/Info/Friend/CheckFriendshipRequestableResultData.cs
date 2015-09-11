namespace Yoda.Net.Networking.Packet.Info.Friend
{
    
    
    using System;
    using System.Collections;


    public class CheckFriendshipRequestableResultData : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.CHECK_FRIENDSHIP_REQUESTABLE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {

            this.requestable = In.readByte();
        }


        public void writeData(PiggStream Out)
        {

            Out.writeByte(requestable);
        }




        public sbyte requestable { get; set; }
    }
}

