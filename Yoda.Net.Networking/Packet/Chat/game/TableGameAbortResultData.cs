using System;
using System.Net;
namespace Yoda.Net.Networking.Packet.Chat.Game.Data
{

    public class TableGameAbortResultData : ICommandData
    {
        public string abortReason;
        public TableGameAbortResultData()
        {

        }
        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_ABORT_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            abortReason = In.readUTF();
        }


        public void writeData(PiggStream Out)
        {
            var wc = new WebClient();
 
            throw new NotImplementedException();
        }


    }
}

