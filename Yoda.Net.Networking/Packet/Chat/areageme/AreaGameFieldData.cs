namespace Yoda.Net.Networking.Packet.Chat.areagame
{
    

    using System;
    using System.Collections;
    
    
    
    


    public class AreaGameFieldData : IPacket
    {
        public AmebaStream data;
        public int id;
        public AreaGameFieldData()
        {

        }
        public AreaGameFieldData(int param1,  AmebaStream param2)
        {
            this.id = param1;
            this.data = param2;
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_FIELD;
            }
        }

        public void readData(AmebaStream In)
        {
        }

        public void writeData(AmebaStream Out)
        {
          //  Engine.Log("AreaGameFieldData::writeData  id="+ id);
            Out.writeInt((short) this.id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

