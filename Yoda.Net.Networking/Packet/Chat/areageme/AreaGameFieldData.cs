namespace Yoda.Net.Networking.Packet.Chat.Areagame
{
    

    using System;
    using System.Collections;

    public class AreaGameFieldData : ICommandData
    {
        public PiggStream data;
        public int id;
        public AreaGameFieldData()
        {

        }
        public AreaGameFieldData(int id,  PiggStream data)
        {
            this.id = id;
            this.data = data;
        }

        public int packetId
        {
            get
            {
                return PacketId.AREA_GAME_FIELD;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeInt((short) this.id);
            data.position = 0;
            Out.writeBytes(data.readBytes((int)data.length));
        }
    }
}

