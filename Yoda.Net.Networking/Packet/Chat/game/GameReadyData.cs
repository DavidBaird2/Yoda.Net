


using System;
namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{


    public class GameReadyData : ICommandData
    {
        public GameReadyData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.GAME_READY;
            }
        }

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();
        }


        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }


    }
}

