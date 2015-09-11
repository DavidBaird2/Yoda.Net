namespace Yoda.Net.Networking.Packet.Info
    
{
    using System;
    using System.Collections;
    public class NotificationData : ICommandData
    {

        public NotificationData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.NOTIFICATION;
            }
        }

        public void readData(PiggStream In)
        {
            this.type = In.readInt();
            this.message = In.readUTF();

            if (In.readBoolean())
            {
                this.data = new PiggStream();
                data.writeBytes(In.toArrayLast());
            }
            return;
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
          
        }



        public string message { get; set; }

        public int type { get; set; }

        public PiggStream data { get; set; }
    }
}

