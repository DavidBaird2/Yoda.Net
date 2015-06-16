using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Data.Common
{
    public class Category
    {
      /*  public const string TYPE_CANDY = "candy";
        public const string TYPE_COSME = "cosmeticitem";
        public static int SCRATCH_CASINO = 14;
        public const string ITEM_GOODS = "goods";
        public const string TYPE_FURNITURE = "furniture";
        public const string ITEM_OTHERS = "others";*/
        public const string COSME_BEARD = "cosme_beard";
      /*  public const string TYPE_GIFT = "gift";
        public const string ACTION_FEEL = "feel";
        public const string FURNITURE_WALL = "wall";*/
        public const string COSME_CONTACT = "cosme_contact";
        public const string COSME_EYELASH = "cosme_eyelash";
      /*  public const string ACTIONITEM_FOOD_EAT = "food_eat";
        public const string TYPE_FISHING_DRINK = "fishing_drink";*/
        public const string COSME_CHEEK = "cosme_cheek";
    /*    public const string GIFT_AME_ITEM = "gift_ame_item";
        public static int SCRATCH_COUPON = 4;
        public const string ACTIONITEM_FOOD_DRINK = "food_drink";
        public const string FURNITURE_FLOOR = "floor";
        public const string ACTIONITEM_TAB_FOOD = "foods";
        public const string TYPE_FISHING_BAIT = "bait";
        public const string ACTIONITEM_TAB_PET = "pet";
        public const string ACTIONITEM_ITEM = "item";
        public const string GIFT_RECOMMEND = "gift_recommend";
        public const string ACTION_DANCE = "dance";
        public const string TYPE_FISHING_CHUM = "fishing_chum";
        public static int SCRATCH_ITEM = 1;
        public const string ACTIONITEM_FOOD_NOODLE = "food_noodle";
        public const string FURNITURE_FRONT = "front";
        public const string TYPE_AME_ITEM = "ame_item";
        public const string FURNITURE_APPLIANCE = "electronics";
        public static int SCRATCH_BATE = 10;
        public const string ITEM_BOTTOMS = "bottoms";
        public const string ITEM_TOPS = "tops";
        public static int SCRATCH_OTHERS = 5;*/
        public const string FURNITURE_OTHERS = "others";
        public const string COSME_EYESHADOW = "cosme_eyeshadow";
      /*  public const string ACTIONITEM_TAB_GOODS = "goods";
        public const string ACTIONITEM_PLACE = "place";
        public const string TYPE_PET = "pet";
        public const string ACTIONITEM_TAB_COSME = "cosme";
        public const string ACTION_COMMU = "commu";
        public const string GIFT_FURNITURE = "gift_furniture";*/
        public const string COSME_EYELINE = "cosme_eyeline";
      /*  public const string FURNITURE_GOODS = "goods";
        public static int SCRATCH_EMPTY = 0;
        public const string GIFT_FASHION = "gift_item";
        public static int SCRATCH_ACTION_ITEM = 3;
        public const string ITEM_SHOES = "shoes";
        public static int SCRATCH_ORIGINAL = 9;
        public const string TYPE_CASINO = "casino";
        public const string ACTIONITEM_FOOD_STRAW = "food_straw";
        public const string FURNITURE_FURNITURE = "furniture";*/
        public const string COSME_MOUTH = "cosme_mouth";
      /*  public static int SCRATCH_FURNITURE = 2;
        public const string ACTION_SPORTS = "sports";
        public const string TYPE_FISHING_EQUIPPABLE = "equippable";
        public static int SCRATCH_FISHING_CHUM = 12;
        public static int SCRATCH_FISHING_DRINK = 13;
        public static int SCRATCH_ROD = 11;
        public const string ITEM_ACCESSORY = "accessory";
        public const string TYPE_HAIR = "hair";*/
        public const string COSME_EYEBROW = "cosme_eyebrow";
    /*    public const string ACTIONITEM_MAGAZINE = "magazine";
        public const string TYPE_COUPON = "coupon";
        public const string TYPE_FISHING_ROD = "rod";
        public const string TYPE_ACTION = "action";
        public const string ACTION_NETA = "neta";
        public const string ACTIONITEM_PET_FOOD = "pet_food";
        public const string ACTIONITEM_ACTION = "action";
        public const string GIFT_ACTION_ITEM = "gift_actionitem";
        public const string ACTIONITEM_WRAPPING = "wrapping";
        public const string TYPE_ACTION_ITEM = "actionitem";
        public const string TYPE_ITEM = "item";
        public const string FURNITURE_WINDOW = "window";*/

        public Category()
        {
            return;
        }

       /* public static string getCategoryByActionItemType(string itemtype)
        {
            if (isFoodActionItem(itemtype))
            {
                return ACTIONITEM_TAB_FOOD;
            }
            if (itemtype == ACTIONITEM_PET_FOOD)
            {
                return ACTIONITEM_TAB_PET;
            }
            return ACTIONITEM_TAB_GOODS;
        }
        */
        public static bool isFoodActionItem(string itemtype)
        {
            return itemtype.IndexOf("food_") == 0;
        }

     /*   public static bool isPlacableActionItem(string itemtype)
        {
            return isFoodActionItem(itemtype) || itemtype == ACTIONITEM_PET_FOOD || itemtype == ACTIONITEM_PLACE;
        }*/

        public static bool checkActionCategoryType(string itemtype, string categorytype)
        {
            return itemtype.IndexOf(categorytype) == 0;
        }

    }
}
