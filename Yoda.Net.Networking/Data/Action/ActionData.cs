
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Action
{
    public class ActionData
    {
        public string type;
        public bool isDefault;
        public string title;
        public string code;
        public string hint;
        public int rareRate;
        public bool isUnlocked;
        public int order;
        public ActionData()
        {
        }
        public ActionData(string type, bool isDefault, string title, string code, int order)
        {
            this.type = type;
            this.isDefault = isDefault;
            this.title = title;
            this.code = code;
            this.order = order;
            return;
        }
        public void readData(PiggStream In)
        {
            code = In.readUTF();
            title = In.readUTF();
            type = In.readUTF();

            if (this.type.IndexOf("over_reaction") == 0)
            {
                this.isUnlocked = In.readBoolean();
                this.rareRate = In.readInt();
                this.hint = In.readUTF();
            }
            order = In.readInt();
            isDefault = In.readBoolean();
        }
        public void writeData(PiggStream Out)
        {
            Out.writeUTF(code);
            Out.writeUTF(title);
            Out.writeUTF(type);

            if (this.type.IndexOf("over_reaction") == 0)
            {
                Out.writeBoolean(this.isUnlocked);
               Out.writeInt(  this.rareRate );
              Out.writeUTF(  this.hint );
            }
            Out.writeInt(order);
            Out.writeBoolean(isDefault);
        }
    }
}
