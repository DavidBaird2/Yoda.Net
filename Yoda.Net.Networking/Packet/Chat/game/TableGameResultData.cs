


namespace Yoda.Net.Networking.Packet.Chat.game.data
{


    public class TableGameResultData : IPacket
    {
        public string method;
        public AmebaStream data;
        public bool serial;

        public virtual int packetId
        {
            get
            {
                return PacketId.TABLE_GAME_RESULT;
            }
        }

        public void readData(AmebaStream In)
        {
            method = In.readUTF();
            serial = In.readBoolean();
            if (In.readBoolean())
            {
                data = new AmebaStream();
                data.writeBytes(In.readBytes((int)(In.length-In.BaseStream.Position)));
                data.position = 0;
            }
        }


        public void writeData(AmebaStream Out)
        {

        }


    }
}

