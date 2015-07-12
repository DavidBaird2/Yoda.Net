
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinData
    {
        public MannequinData(MannequinIdData data = null)
        {

            if (data == null)
            {
                this.mannequinId = new MannequinIdData();
            }
            else
            {
                this.mannequinId = data;
            }
            this.item = new MannequinBodyItemData();
        }

        public MannequinIdData mannequinId;

        public MannequinBodyItemData item;

        public void readData(PiggStream stream)
        {
            this.mannequinId.readData(stream);
            this.item = new MannequinBodyItemData();
            this.item.readData(stream);
        }

        public void readmannequinIdsAndItemUniqueIdsData(PiggStream stream)
        {
            this.mannequinId.readData(stream);
            this.item = new MannequinBodyItemData();
            this.item.readUniqueIdData(stream);
        }

        public void readmannequinIdData(PiggStream stream)
        {
            this.mannequinId.readData(stream);
        }

        public void readDataEnterRoom(PiggStream stream)
        {
            this.mannequinId.readAreaCodeAndSequenceData(stream);
            this.item = new MannequinBodyItemData();
            this.item.readData(stream);
        }
        public void writeDataEnterRoom(PiggStream stream)
        {
            mannequinId.writeAreaCodeAndSequenceData(stream);
            this.item.writeData(stream);
        }
        public void readAllData(PiggStream stream)
        {
            this.mannequinId.readData(stream);
            this.item = new MannequinBodyItemData();
            this.item.readDataWithUniqueId(stream);
        }

        public void readDataWithUniqueId(PiggStream stream)
        {
            this.mannequinId.readAreaCodeAndSequenceData(stream);
            this.item = new MannequinBodyItemData();
            this.item.readDataWithUniqueId(stream);
        }

        public void writeSaveMannequin(PiggStream stream)
        {
            this.mannequinId.writeData(stream);
            this.item.writeUniqueIdsData(stream);
        }

        public bool hasItem(int code)
        {
            if (this.item == null)
            {
                return false;
            }
            return this.item.hasItem(code);
        }

        public int getItemIndex(int index)
        {
            if (this.item == null)
            {
                return -1;
            }
            return this.item.getItemIndex(index);
        }


    }
}
