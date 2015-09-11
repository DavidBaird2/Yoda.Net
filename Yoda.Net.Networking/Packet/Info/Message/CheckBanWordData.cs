using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.Message
{
    public class CheckBanWordData : ICommandData
    {
       public static int UPDATE_CONFIG = 1;                      //slotID:1
		public static int TALK = 17;                              //slotID:2
		public static int TABLE_GAME_TALK = 18;                   //slotID:3
		public static int SEND_MESSAGE = 33;                     //slotID:4
		public static int SEND_ARCHIVE_MESSAGE = 34;              //slotID:5
		public static int REQUEST_FRIENDSHIP = 49;                //slotID:6
		public static int INVITE_SEND_MAIL = 65;                  //slotID:7
		public static int CREATE_CLUB = 81;                       //slotID:8
		public static int SEARCH_CLUB = 82;                       //slotID:9
		public static int INVITE_CLUB = 83;                       //slotID:10
		public static int REQUEST_CLUB = 84;                      //slotID:11
		public static int ADD_CLUB_MESSAGE = 85;                  //slotID:12
		public static int POST_CONTEST = 97;                      //slotID:13


        public CheckBanWordData()
        {
            return;
        }

        public int packetId
        {
            get
            {
                return PacketId.CHECK_BAN_WORD;
            }
        }

        public void readData(PiggStream In)
        {
            commandType = In.readShort();
            msg = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeShort(this.commandType);
            Out.writeUTF(this.msg);
        }

        public string msg { get; set; }

        public short commandType { get; set; }
    }
}
