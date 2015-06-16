using Yoda.Net.Networking.Data.Common;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinBodyItemData:BodyItemData
    {
              public  MannequinBodyItemData() {

         this.uniqueIds = new List<int>();
      }
      
      public List<int> uniqueIds;
      
       public new void readData(AmebaStream param1)  {
         var _loc2_ = param1.readByte();
         items = new ArrayList(_loc2_);
         this.uniqueIds = new List<int>();
         var _loc3_ = 0;
         while (_loc3_ < _loc2_)
         {
            items.Add(param1.readUTF());
            _loc3_++;
         }
      }
      
      public void readUniqueIdData(AmebaStream param1)  {
        var _loc2_ = param1.readByte();
         items = new ArrayList(_loc2_);
         this.uniqueIds = new List<int>();
         var _loc3_ = 0;
         while(_loc3_ < items.Count)
         {
            this.uniqueIds[_loc3_] = param1.readInt();
            _loc3_++;
         }
      }
      
      public void readDataWithUniqueId(AmebaStream param1)  {
         int _loc2_ = param1.readByte();
          items = new ArrayList(_loc2_);
         this.uniqueIds = new List<int>();
         var _loc3_ = 0;
         while(_loc3_ < items.Count)
         {
            items[_loc3_] = param1.readUTF();
            this.uniqueIds[_loc3_] = param1.readInt();
            _loc3_++;
         }
      }
      
      public void writeUniqueIdsData(AmebaStream param1)  {
         var _loc2_ = 0;
         param1.writeByte((byte)this.uniqueIds.Count);
         var _loc3_ = 0;
         while(_loc3_ < this.uniqueIds.Count)
         {
            _loc2_ = this.uniqueIds[_loc3_];
            param1.writeInt(_loc2_);
            _loc3_++;
         }
      }
      
      public bool hasItem(int param1)  {
         var _loc2_ = 0;
         var _loc3_ = 0;
         _loc3_ = this.uniqueIds.Count;
         _loc2_ = 0;
         while(_loc2_ < _loc3_)
         {
            if(param1 == this.uniqueIds[_loc2_])
            {
               return true;
            }
            _loc2_++;
         }
         return false;
      }
      
      public int getItemIndex(int param1)  {
         var _loc2_ = 0;
         var _loc3_ = 0;
         _loc3_ = this.uniqueIds.Count;
         _loc2_ = 0;
         while(_loc2_ < _loc3_)
         {
            if(param1 == this.uniqueIds[_loc2_])
            {
               return _loc2_;
            }
            _loc2_++;
         }
         return -1;
      }
    }
}
