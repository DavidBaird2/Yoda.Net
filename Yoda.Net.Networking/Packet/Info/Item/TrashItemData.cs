namespace Yoda.Net.Networking.Packet.Info.Item
{
    
    using System;
    
    using System.Collections;
    public class TrashItemData : ICommandData, IEncrypted, IncludeClientTime
    {
        public string type;
        public int stockId;
        public string code;


        private int count;
        public int packetId
        {
            get
            {
                return PacketId.TRASH_ITEM;
            }
        }
        public TrashItemData()
        {
        }
        public TrashItemData(string type, int stockId, string code,int count = 1)
        {
            this.type = type;
            this.stockId = stockId;
            this.code = code;
            this.count = count;
            return;
        }
        public void readData(PiggStream In)
        {
            type = In.readUTF();
            code = In.readUTF();
            stockId = In.readInt();
            count = In.readInt();
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(type);
            Out.writeUTF(code);
            Out.writeInt(stockId);
            Out.writeInt(count);
            return;
        }
    }
}

