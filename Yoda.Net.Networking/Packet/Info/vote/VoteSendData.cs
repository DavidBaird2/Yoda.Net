namespace pigg.net.info.data.vote
{
    

    using System;
    using System.Runtime.InteropServices;
    
using System.Collections;
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;


    public class VoteSendData : IPacket
    {
        private string _code;
        private ArrayList _userAnswers;

        public VoteSendData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.VOTE_SEND;
            }
        }

        public void readData(AmebaStream In)
        {
     
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(this._code);
            Out.writeInt(0);
            return;
        }

    }
}

