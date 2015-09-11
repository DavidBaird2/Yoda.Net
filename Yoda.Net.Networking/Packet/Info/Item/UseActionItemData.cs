namespace Yoda.Net.Networking.Packet.Info.Item
{
    
    using System;
    
    using System.Collections;
    public class UseActionItemData : ICommandData
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

        public void readData(PiggStream In)
        {
            actionItemCode = In.readUTF();
            areaCategory = In.readUTF();
            areaCode = In.readUTF();
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(actionItemCode);
            Out.writeUTF(areaCategory);
            Out.writeUTF(areaCode);
        }
    }
}

