namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGamePlayData : ICommandData
    {
        public PiggStream data;
        public int id;


        public AreaGamePlayData()
        {
        }
        public AreaGamePlayData(int id, PiggStream data)
        {
            this.id = id;
            this.data = data;
        }
        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_PLAY;
            }
        }

        public void readData(PiggStream In)
        {
            id = In.readInt();
            data = new PiggStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt(id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

