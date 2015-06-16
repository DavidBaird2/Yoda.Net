namespace Yoda.Net.Networking.Packet.Info.area
{
    
    using System;
    

    public class NotifyUserRoomEnteredData : IPacket
    {
        public string _areaCode;

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_USER_ROOM_ENTERED;
            }
        }
        public NotifyUserRoomEnteredData(string param1)
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

