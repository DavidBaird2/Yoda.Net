namespace Yoda.Net.Networking.Packet.Vote
{


    using System;
    using System.Runtime.InteropServices;

    using System.Collections;
    using Yoda.Net.Networking.Packet.Info;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Packet;


    public class VoteSendData : ICommandData
    {
        public string code;
        //  private ArrayList userAnswers;

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

        public void readData(PiggStream In)
        {
            throw new NotImplementedException();

        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.code);
            Out.writeInt(0);
            return;
        }

    }
}

