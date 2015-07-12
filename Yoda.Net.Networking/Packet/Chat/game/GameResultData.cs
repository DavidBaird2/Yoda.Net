

using System;
namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class GameResultData : ICommandData
    {
        public int id;
        public PiggStream data;

        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_RESULT_DATA;
            }
        }

        public void readData(PiggStream In)
        {
            id = In.readShort();
            data = new PiggStream();
            data.writeBytes(In.readBytes((int)(In.length - In.BaseStream.Position)));
            data.position = 0;
            
        }


        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }


    }
}

