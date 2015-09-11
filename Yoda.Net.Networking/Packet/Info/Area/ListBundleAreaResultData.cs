
namespace Yoda.Net.Networking.Packet.Info.Area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Data.Common;

    public class ListBundleAreaResultData : ICommandData
    {
        public string bundle;
        public string enterableDescription;
        public bool enterable;
        public string areaName;
        public ArrayList list;

        public int packetId
        {
            get
            {
                return PacketId.LIST_AREA_BUNDLE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            AreaData area = null;
            areaName = In.readUTF();
            bundle = In.readUTF();
            int areacount = In.readInt();
            list = new ArrayList();
            int i = 0;
            while (i < areacount)
            {
                
                area = new AreaData();
                area.areaCode = In.readUTF();
                area.categoryCode = In.readUTF();
                area.name = In.readUTF();
                area.description = In.readUTF();
                area.isComingSoon = In.readBoolean();
                area.game = In.readBoolean();
                area.shop = In.readBoolean();
                area.timeTravel = In.readBoolean();
                area.capacity = In.readInt();
                area.currentCount = In.readInt();
                list.Add(area);
                i++;
            }
            enterable = In.readBoolean();
            if (!enterable)
            {
                enterableDescription = In.readUTF();
            }
            return;
        }
        public ListBundleAreaResultData()
        {
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(areaName);
            Out.writeUTF(bundle);
            Out.writeInt(list.Count);
            foreach(AreaData areadata in list)
            {
                Out.writeUTF(areadata.areaCode);
                Out.writeUTF(areadata.categoryCode);
                Out.writeUTF(areadata.name);
                Out.writeUTF(areadata.description);
                Out.writeBoolean(areadata.isComingSoon);
                Out.writeBoolean(areadata.game);
                Out.writeBoolean(areadata.shop);
                Out.writeBoolean(areadata.timeTravel);
                Out.writeInt(areadata.capacity);
                Out.writeInt(areadata.currentCount);
            }
            Out.writeBoolean(enterable);
            if (!enterable)
            {
                Out.writeUTF(enterableDescription);
            }
            return;
        }
    }
}

