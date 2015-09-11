using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Common
{
    public class Category
    {

        public const string COSME_BEARD = "cosme_beard";

        public const string COSME_CONTACT = "cosme_contact";
        public const string COSME_EYELASH = "cosme_eyelash";
        public const string COSME_CHEEK = "cosme_cheek";

        public const string FURNITURE_OTHERS = "others";
        public const string COSME_EYESHADOW = "cosme_eyeshadow";

        public const string COSME_EYELINE = "cosme_eyeline";

        public const string COSME_MOUTH = "cosme_mouth";

        public const string COSME_EYEBROW = "cosme_eyebrow";


        public Category()
        {
            return;
        }


        public static bool isFoodActionItem(string itemtype)
        {
            return itemtype.IndexOf("food_") == 0;
        }


        public static bool checkActionCategoryType(string itemtype, string categorytype)
        {
            return itemtype.IndexOf(categorytype) == 0;
        }

    }
}
