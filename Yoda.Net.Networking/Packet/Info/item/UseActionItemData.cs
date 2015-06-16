namespace Yoda.Net.Networking.Packet.Info.item
{
    
    using System;
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common;
    public class UseActionItemData : IPacket
    {
               public string areaCategory;
               public string areaCode;
               public string actionItemCode;

          public UseActionItemData(string actionItemCode, string areaCategory, string areaCode)
        {
            this.actionItemCode = actionItemCode;
            this.areaCategory = areaCategory;
            this.areaCode = areaCode;
        }
          public UseActionItemData()
          {
    
          }

        public int packetId
        {
            get
            {
                return PacketId.USE_ACTION_ITEM;
            }
        }

        public void readData(AmebaStream In)
        {
            actionItemCode = In.readUTF();
            areaCategory = In.readUTF();
            areaCode = In.readUTF();
        }

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(actionItemCode);
            Out.writeUTF(areaCategory);
            Out.writeUTF(areaCode);
        }
    }
}

