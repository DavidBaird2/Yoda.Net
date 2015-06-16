namespace Yoda.Net.Networking.Packet.Chat
{
    
    using System;
    

    public class EnterRoomData :  IPacket,IEncrypted,IncludeClientTime
    {
 
        public bool queue;
        public string code;
        public string category;
        public int fromMove { get; set; }
        public int packetId
        {
            get
            {
                return PacketId.ENTER_ROOM;
            }
        }
        public EnterRoomData()
        {
            return;
        }



        public void readData(AmebaStream In)
        {
            category = In.readUTF();
            code = In.readUTF();
            queue = In.readBoolean();
            fromMove = In.readInt();
            return;
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(category);
            Out.writeUTF(code);

            Out.writeBoolean(queue);
            Out.writeInt(this.fromMove);
          
            return;
        }



    }
}

