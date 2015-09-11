namespace Yoda.Net.Networking.Packet.Info.Area
{
    
    using System;
    

    public class NotifyUserRoomEnteredData : ICommandData
    {
        public NotifyUserRoomEnteredData()
        {
        }
        public string areaCode;

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_USER_ROOM_ENTERED;
            }
        }
        public NotifyUserRoomEnteredData(string areaCode)
        {
            this.areaCode = areaCode;
        }
        public void readData(PiggStream In)
        {
            areaCode = In.readUTF();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(areaCode);
            return;
        }
    }
}

