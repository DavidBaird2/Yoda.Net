


using System;
namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameResultData : ICommandData
    {
        public string method;
        public PiggStream data;
        public bool serial;
        public TableGameResultData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            method = In.readUTF();
            serial = In.readBoolean();
            if (In.readBoolean())
            {
                data = new PiggStream();
                data.writeBytes(In.readBytes((int)(In.length - In.BaseStream.Position)));
                data.position = 0;
            }
        }


        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }


    }
}

