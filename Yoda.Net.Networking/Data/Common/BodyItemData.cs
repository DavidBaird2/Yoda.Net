namespace Yoda.Net.Networking.Data.Common
{
    
    using System;
    using System.Collections;
    using Yoda.Net.Networking;

    public class BodyItemData
    {
        public ArrayList items;

        public void readData(PiggStream In)
        {
            int count = In.readInt();
            this.items = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                this.items.Add(In.readUTF());
            }
        }

        public void writeData(PiggStream Out)
        {
            if (this.items == null)
            {
                Out.writeInt(0);
            }
            else
            {
                Out.writeInt(this.items.Count);
                for (int i = 0; i < this.items.Count; i++)
                {
                    Out.writeUTF(this.items[i].ToString());
                }
            }
        }
    }
}

