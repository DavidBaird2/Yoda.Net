
namespace Yoda.Net.Networking.Packet.Info.area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    using Yoda.Net.Networking.Packet.Data.common.test;

    public class ListBundleAreaResultData : IPacket
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

        public void readData(AmebaStream In)
        {
            AreaData _loc_4 = null;
            areaName = In.readUTF();
            bundle = In.readUTF();
            int _loc_2 = In.readInt();
            list = new ArrayList();
            int _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {
                
                _loc_4 = new AreaData();
                _loc_4.areaCode = In.readUTF();
                _loc_4.categoryCode = In.readUTF();
                _loc_4.name = In.readUTF();
                _loc_4.description = In.readUTF();
                _loc_4.isComingSoon = In.readBoolean();
                _loc_4.game = In.readBoolean();
                _loc_4.shop = In.readBoolean();
                _loc_4.timeTravel = In.readBoolean();
                _loc_4.capacity = In.readInt();
                _loc_4.currentCount = In.readInt();
                list.Add(_loc_4);
                _loc_3++;
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

        public void writeData(AmebaStream Out)
        {
            Out.writeUTF(areaName);
            Out.writeUTF(bundle);
            Out.writeInt(list.Count);
            foreach(AreaData _loc_4 in list)
            {
                Out.writeUTF(_loc_4.areaCode);
                Out.writeUTF(_loc_4.categoryCode);
                Out.writeUTF(_loc_4.name);
                Out.writeUTF(_loc_4.description);
                Out.writeBoolean(_loc_4.isComingSoon);
                Out.writeBoolean(_loc_4.game);
                Out.writeBoolean(_loc_4.shop);
                Out.writeBoolean(_loc_4.timeTravel);
                Out.writeInt(_loc_4.capacity);
                Out.writeInt(_loc_4.currentCount);
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

