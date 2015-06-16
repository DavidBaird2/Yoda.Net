
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinData
    {
        public MannequinData(MannequinIdData param1 = null)
        {

            if (param1 == null)
            {
                this.mannequinId = new MannequinIdData();
            }
            else
            {
                this.mannequinId = param1;
            }
            this.item = new MannequinBodyItemData();
        }

        public MannequinIdData mannequinId;

        public MannequinBodyItemData item;

        public void readData(AmebaStream param1)
        {
            this.mannequinId.readData(param1);
            this.item = new MannequinBodyItemData();
            this.item.readData(param1);
        }

        public void readmannequinIdsAndItemUniqueIdsData(AmebaStream param1)
        {
            this.mannequinId.readData(param1);
            this.item = new MannequinBodyItemData();
            this.item.readUniqueIdData(param1);
        }

        public void readmannequinIdData(AmebaStream param1)
        {
            this.mannequinId.readData(param1);
        }

        public void readDataEnterRoom(AmebaStream param1)
        {
            this.mannequinId.readAreaCodeAndSequenceData(param1);
            this.item = new MannequinBodyItemData();
            this.item.readData(param1);
        }

        public void readAllData(AmebaStream param1)
        {
            this.mannequinId.readData(param1);
            this.item = new MannequinBodyItemData();
            this.item.readDataWithUniqueId(param1);
        }

        public void readDataWithUniqueId(AmebaStream param1)
        {
            this.mannequinId.readAreaCodeAndSequenceData(param1);
            this.item = new MannequinBodyItemData();
            this.item.readDataWithUniqueId(param1);
        }

        public void writeSaveMannequin(AmebaStream param1)
        {
            this.mannequinId.writeData(param1);
            this.item.writeUniqueIdsData(param1);
        }

        public bool hasItem(int param1)
        {
            if (this.item == null)
            {
                return false;
            }
            return this.item.hasItem(param1);
        }

        public int getItemIndex(int param1)
        {
            if (this.item == null)
            {
                return -1;
            }
            return this.item.getItemIndex(param1);
        }

        public MannequinData clone()
        {
            MannequinData _loc1_ = new MannequinData(this.mannequinId.clone());
            if (this.item.items != null)
            {
                //   _loc1_.item.items = this.item.items.concat();
            }
            return _loc1_;
        }
    }
}
