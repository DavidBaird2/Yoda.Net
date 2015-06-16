using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Pet
{
    public class PetSolveFurniturePlaceData
    {
          public string furnitureId;
      
      public int roomIndex;
      
      public int countSelf;
      
      public int countOther;
      
      public int countMax;
      
     /* public function get solveType() : String {
         var _loc1_:Array = this.furnitureId.split("_");
         return _loc1_[2];
      }*/
      
      public bool isAme  {
    get{
         return this.furnitureId.IndexOf("_ame") != -1;}
      }
      
    /*  public function addPetId(param1:int) : void {
      }
      
      public function isIncludePetId(param1:int) : Boolean {
         return false;
      }*/
    }
}
