namespace Yoda.Net.Networking.Packet.Chat
{




    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Room;
    public class EnterUserGardenResultData : EnterUserRoomResultData
    {

        public EnterUserGardenResultData()
        {
        }

        public override int packetId
        {
            get
            {
                return PacketId.ENTER_USER_GARDEN_RESULT;
            }
        }
        public override string commandType
        {
            get
            {
                return AreaData.TYPE_GARDEN;
            }
        }
        override protected void readCodeData(PiggStream stream)
        {
            areaData.skyCode = stream.readUTF();
            areaData.houseCode = stream.readUTF();
            areaData.groundCode = stream.readUTF();
            areaData.roadCode = stream.readUTF();
            return;
        }
        override protected void writeCodeData(PiggStream stream)
        {
            stream.writeUTF(areaData.skyCode);
            stream.writeUTF(areaData.houseCode);
            stream.writeUTF(areaData.groundCode);
            stream.writeUTF(areaData.roadCode);

            return;
        }
        override public void readData(PiggStream stream)
        {
            bool found = false;
            var userCode = "";
            base.readData(stream);
            found = stream.readBoolean();
            if (found)
            {
                userCode = stream.readUTF();
                shuffleGoOutData = new ShuffleGoOutData(userCode);
            }
            return;
        }
        override public void writeData(PiggStream stream)
        {

            base.writeData(stream);

            if (shuffleGoOutData != null)
            {
                stream.writeBoolean(shuffleGoOutData != null);
                stream.writeUTF(shuffleGoOutData.userCode);

            }
            return;
        }
    }
}

