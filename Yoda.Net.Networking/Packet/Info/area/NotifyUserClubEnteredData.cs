namespace Yoda.Net.Networking.Packet.Info.area
{
    
    using System;
    

    public class NotifyUserClubEnteredData : ICommandData
    {
        public NotifyUserClubEnteredData()
        {
        }
        public string areaCode;

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_CLUB_ROOM_ENTERED;
            }
        }
        public NotifyUserClubEnteredData(string _areaCode)
        {
            this.areaCode = _areaCode;
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

