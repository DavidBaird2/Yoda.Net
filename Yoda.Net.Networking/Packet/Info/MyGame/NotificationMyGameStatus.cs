using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Mygame;



namespace Yoda.Net.Networking.Packet.Info.MyGame
{
    public class NotificationMyGameStatus : ICommandData
    {
        public string msg;
        public bool isBan;

        public int packetId
        {
            get
            {
                return PacketId.NOTIFY_MYGAME_STATUS;
            }
        }

        public void readData(PiggStream In)
        {
            MyGameExternalGameData myGameData = null;
            int couny = In.readInt();

            this.list = new List<MyGameExternalGameData>();

            couny.Times(() =>
            {
                myGameData = new MyGameExternalGameData();
                myGameData.serviceName = In.readUTF();
                myGameData.serviceStatus = In.readByte();
                myGameData.imgType = In.readByte();
                myGameData.linkHeader = In.readUTF();
                this.list.Add(myGameData);

            });
        }

        public void writeData(PiggStream Out)
        {
            throw new NotImplementedException();
        }

        public List<MyGameExternalGameData> list { get; set; }
    }
}
