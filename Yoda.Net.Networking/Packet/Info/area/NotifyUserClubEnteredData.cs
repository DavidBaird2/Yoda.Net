namespace Yoda.Net.Networking.Packet.Info.area
{
    
    using System;
    

    public class NotifyUserClubEnteredData : IPacket
    {
        public string _areaCode;

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_CLUB_ROOM_ENTERED;
            }
        }
        public NotifyUserClubEnteredData(string param1)
        {
            _areaCode = param1;
        }
        public void readData(AmebaStream In)
        {
            _areaCode = In.readUTF();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(_areaCode);
            return;
        }
    }
}

