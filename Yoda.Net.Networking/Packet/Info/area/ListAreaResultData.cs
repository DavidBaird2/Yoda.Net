using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

using Yoda.Net.Networking.Packet.Data.common;
using Yoda.Net.Networking.Packet.Data.common.test;

namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListAreaResultData:IPacket
    {
        public ArrayList areaCategories;
        public int openAreaType;
        public int userZone;

        public int packetId
        {
            get
            {
                return 0x501;
            }
        }

        public void readData(AmebaStream In)
        {
            AreaCategoryData data = null;
            int num = 0;
            int num2 = 0;
            AreaData data2 = null;
            this.userZone = In.readByte();
            this.openAreaType = In.readInt();

            int capacity = In.readInt();
            this.areaCategories = new ArrayList(capacity);
            for (int i = 0; i < capacity; i++)
            {
                data = new AreaCategoryData {
                    code = In.readUTF(),
                    bundle = In.readUTF(),
                    name = In.readUTF(),
                    publicDescription = In.readUTF(),
                    isComingSoon = In.readBoolean(),
                    isNew = In.readBoolean(),
                    isTimeTravel = In.readBoolean(),
                    allowedZone = In.readByte()
                };
                num = In.readInt();
                for (num2 = 0; num2 < num; num2++)
                {
                    data2 = new AreaData();
                        data2.categoryCode = In.readUTF();
                        data2.areaCode = In.readUTF();
                        data2.bundle = In.readUTF();
                        data2.name = In.readUTF();
                        data2.description = In.readUTF();
                        data2.isOpen = In.readBoolean();
                        data2.isNew = In.readBoolean();
                        data2.isComingSoon = In.readBoolean();
                        data2.shop = In.readBoolean();
                        data2.game = In.readBoolean();
                        data2.areaGameId = In.readByte();
                        data2.capacity = In.readInt();
                        data2.currentCount = In.readInt();
                        data2.isStreaming = In.readBoolean();
                        data2.defaultAreaCount = In.readInt();
                        data2.maxArea = In.readInt();
                        data2.maxPeople = In.readInt();
                        data2.isEnterable = In.readBoolean();
                        data2.isBecomeEnterable = In.readBoolean();
                        data2.becomeEnterableMessage = In.readUTF();
                        data2.allowedZone = In.readByte();
                        data2.isConfirmationDisabled = In.readBoolean();
                        data2.hasUrl = In.readBoolean();
                        if (data2.hasUrl == true)
                        {
                            data2.url = In.readUTF();
                            data2.isUrlAvailable = In.readBoolean();
                        }
                        data2.isOutline = In.readBoolean();
                        data2.piggWorld = In.readBoolean();
                    
                    data.list.Add(data2);
                }
                this.areaCategories.Insert(i, data);
            }
        }

        public void writeData(AmebaStream Out)
        {
            int num = 0;
            int num2 = 0;
            AreaData data2 = null;
            Out.writeByte((byte)this.userZone);
            Out.writeInt(this.openAreaType);

            int capacity = areaCategories.Count;
            Out.writeInt(capacity);
            for (int i = 0; i < capacity; i++)
            {
                var data1 = (AreaCategoryData)areaCategories[i];
                    Out.writeUTF(data1.code);
                    Out.writeUTF(data1.bundle);
                    Out.writeUTF(data1.name);
                    Out.writeUTF(data1.publicDescription);
                    Out.writeBoolean(data1.isComingSoon);
                    Out.writeBoolean(data1.isNew);
                    Out.writeBoolean(data1.isTimeTravel);
                    Out.writeByte((byte)data1.allowedZone);
                    num = data1.list.Count;
                Out.writeInt(num);
                for (num2 = 0; num2 < num; num2++)
                {
                    data2 = (AreaData)data1.list[num2];
                    Out.writeUTF(data2.categoryCode);
                    Out.writeUTF(data2.areaCode);
                    Out.writeUTF(data2.bundle);
                    Out.writeUTF(data2.name);
                    Out.writeUTF(data2.description);
                    Out.writeBoolean(data2.isOpen);
                    Out.writeBoolean(data2.isNew);
                    Out.writeBoolean(data2.isComingSoon);
                    Out.writeBoolean(data2.shop);
                    Out.writeBoolean(data2.game);
                    Out.writeByte((byte)data2.areaGameId);
                    Out.writeInt(data2.capacity);
                    Out.writeInt(data2.currentCount);
                    Out.writeBoolean(data2.isStreaming);
                    Out.writeInt(data2.defaultAreaCount);
                    Out.writeInt(data2.maxArea);
                    Out.writeInt(data2.maxPeople);
                    Out.writeBoolean(data2.isEnterable);
                    Out.writeBoolean(data2.isBecomeEnterable);
                    Out.writeUTF(data2.becomeEnterableMessage);
                    Out.writeByte((byte)data2.allowedZone);
                    Out.writeBoolean(data2.isConfirmationDisabled);
                    Out.writeBoolean(data2.hasUrl);
                    if (data2.hasUrl == true)
                    {
                        Out.writeUTF(data2.url);
                        Out.writeBoolean(data2.isUrlAvailable);
                    }
                    Out.writeBoolean(data2.isOutline);
                    Out.writeBoolean(data2.piggWorld);
                }
            }
        }
    }
}

