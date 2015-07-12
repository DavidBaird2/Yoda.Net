using Yoda.Net.Networking.Data.Common;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinBodyItemData : BodyItemData
    {
        public MannequinBodyItemData()
        {

            this.uniqueIds = new List<int>();
        }

        public List<int> uniqueIds;

        public new void readData(PiggStream stream)
        {
            var count = stream.readByte();
            items = new ArrayList(count);
            this.uniqueIds = new List<int>();
            var i = 0;
            while (i < count)
            {
                items.Add(stream.readUTF());
                i++;
            }
        }


        public new void writeData(PiggStream stream)
        {
            stream.writeByte((byte)items.Count);


            foreach (string text in items)
            {
                stream.writeUTF(text);
            }
        }


        public void readUniqueIdData(PiggStream stream)
        {
            var count = stream.readByte();
            items = new ArrayList(count);
            this.uniqueIds = new List<int>();
            var i = 0;
            while (i < items.Count)
            {
                this.uniqueIds[i] = stream.readInt();
                i++;
            }
        }

        public void readDataWithUniqueId(PiggStream stream)
        {
            int count = stream.readByte();
            items = new ArrayList(count);
            this.uniqueIds = new List<int>();
            var i = 0;
            while (i < items.Count)
            {
                items[i] = stream.readUTF();
                this.uniqueIds[i] = stream.readInt();
                i++;
            }
        }

        public void writeUniqueIdsData(PiggStream stream)
        {
            var count = 0;
            stream.writeByte((byte)this.uniqueIds.Count);
            var i = 0;
            while (i < this.uniqueIds.Count)
            {
                count = this.uniqueIds[i];
                stream.writeInt(count);
                i++;
            }
        }

        public bool hasItem(int id)
        {
            var i = 0;
            var uniqueidCount = 0;
            uniqueidCount = this.uniqueIds.Count;
            i = 0;
            while (i < uniqueidCount)
            {
                if (id == this.uniqueIds[i])
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public int getItemIndex(int id)
        {
            var i = 0;
            var uniqueidCount = 0;
            uniqueidCount = this.uniqueIds.Count;
            i = 0;
            while (i < uniqueidCount)
            {
                if (id == this.uniqueIds[i])
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
