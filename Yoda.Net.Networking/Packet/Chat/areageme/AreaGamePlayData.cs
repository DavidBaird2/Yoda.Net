namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    


    public class AreaGamePlayData : IPacket
    {
        public AmebaStream data;
        public int id;


        public AreaGamePlayData()
        {
        }
        public AreaGamePlayData(int param1, AmebaStream param2)
        {
            id = param1;
            data = param2;
        }
        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_PLAY;
            }
        }

        public void readData(AmebaStream In)
        {
            id = In.readInt();
            data = new AmebaStream();
            data.writeBytes(In.readBytes((int)(In.length - In.position)));
            data.position = 0;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeInt(id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

