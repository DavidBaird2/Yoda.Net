using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Room;




namespace Yoda.Net.Networking.Packet.Chat
{
    public class ChangeRoomResultData : IPacket, IEncrypted
    {
        public int type;
        public DefineFurniture define;

        public ChangeRoomResultData()
        {
        }

        public int packetId
        {
            get
            {
                return PacketId.CHANGE_ROOM_RESULT;
            }
        }

        public void readData(AmebaStream param1)
        {
            type = param1.readByte();
            if (param1.readBoolean())
            {
               int partCount =  param1.readShort();
                define = new DefineFurniture();
                define.characterId = param1.readUTF();
                define.type = param1.readByte();
                define.category = param1.readUTF();
                define.name = param1.readUTF();
                define.description = param1.readUTF();
                define.actionCode = param1.readUTF();
            /*    foreach(int i = 0;i <partCount;int++)
                {
                    
                }*/
            }
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeByte((byte)type);
            if (define != null)
            {
                Out.writeBoolean(true);
                Out.writeShort(0);
                Out.writeUTF(define.characterId);
                Out.writeUTF(define.category);
                Out.writeUTF(define.name);
                Out.writeUTF(define.description);
                Out.writeUTF(define.actionCode);
            }
            else
            {
                Out.writeBoolean(false);
            }
            return;
        }
    }
}
