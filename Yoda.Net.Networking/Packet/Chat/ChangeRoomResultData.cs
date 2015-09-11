using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Data.Room;




namespace Yoda.Net.Networking.Packet.Chat
{
    public class ChangeRoomResultData : ICommandData
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

        public void readData(PiggStream stream)
        {
            type = stream.readByte();
            if (stream.readBoolean())
            {
               int partCount =  stream.readShort();
                define = new DefineFurniture();
                define.characterId = stream.readUTF();
                define.type = stream.readByte();
                define.category = stream.readUTF();
                define.name = stream.readUTF();
                define.description = stream.readUTF();
                define.actionCode = stream.readUTF();
                define.parts = new List<PartData>();
                for(int i = 0;i<partCount;i++)
                {
                    var parts = new PartData();
                    parts.readData(stream, true);
                    define.parts.Add(parts);
                }

            }
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeByte((byte)type);
            if (define != null)
            {
                Out.writeBoolean(true);
                Out.writeShort((short)define.parts.Count);
                Out.writeUTF(define.characterId);
                Out.writeUTF(define.category);
                Out.writeUTF(define.name);
                Out.writeUTF(define.description);
                Out.writeUTF(define.actionCode);
                foreach(PartData part in define.parts)
                {
                    part.writeData(Out, true);
                }
            }
            else
            {
                Out.writeBoolean(false);
            }
            return;
        }
    }
}
