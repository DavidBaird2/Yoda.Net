namespace Yoda.Net.Networking.Packet.Info.friend
{
    
    
    using System;
    using System.Collections;


    public class  : ICommandData
    {

        public int packetId
        {
            get
            {
                return PacketId.;
            }
        }

        public void readData(PiggStream In)
        {

           
        }


        public void writeData(PiggStream Out)
        {

            throw new NotImplementedException();
        }


    }
}

