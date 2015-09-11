using Yoda.Net.Networking.Data.Common;
namespace Yoda.Net.Networking.Packet.Chat
{


    public class AppearUserData : ICommandData
    {
        public AvatarData avatarData;
        public int roomIndex;
        public AppearUserData()
        {

        }

        public void readData(PiggStream In)
        {
            this.avatarData = new AvatarData();
            this.avatarData.readData(In);
            this.roomIndex = In.readInt();
        }

        public void writeData(PiggStream Out)
        {
            this.avatarData.writeData(Out);
            Out.writeInt(roomIndex);
        }

        public int packetId
        {
            get
            {
                return PacketId.APPEAR_USER;
            }
        }
    }
}

