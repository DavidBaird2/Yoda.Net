using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Yoda.Net.Networking.Packet.Info.area
{
    public class ListBundleAreaData : ICommandData
    {
        public int defaultAreaCount;
        public string bundle;
        public int maxArea;
        public int maxPeople;
        public int currentCount;
        public bool isStreaming;
        public string areaCode;
        public string areaName;
        public string categoryId;
        public int capacity;

        public int packetId
        {
            get
            {
                return PacketId.LIST_AREA_BUNDLE;
            }
        }

        public void readData(PiggStream In)
        {
            this.categoryId = In.readUTF();
            this.areaCode = In.readUTF();
            this.bundle = In.readUTF();
            this.areaName = In.readUTF();
            this.isStreaming = In.readBoolean();
            this.capacity = In.readInt();
            this.currentCount = In.readInt();
            this.defaultAreaCount = In.readInt();
            this.maxArea = In.readInt();
            this.maxPeople = In.readInt();
        }
        public ListBundleAreaData(string _categoryId, string _areaCode, string _bundle, string _areaName, bool _isStreaming, int _capacity, int _currentCount, int _defaultAreaCount, int _maxArea, int _maxPeople)
        {
            this.categoryId = _categoryId;
            this.areaCode = _areaCode;
            this.bundle = _bundle;
            this.areaName = _areaName;
            this.isStreaming = _isStreaming;
            this.capacity = _capacity;
            this.currentCount = _currentCount;
            this.defaultAreaCount = _defaultAreaCount;
            this.maxArea = _maxArea;
            this.maxPeople = _maxPeople;
            return;
        }
        public ListBundleAreaData()
        {
            return;
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(categoryId);
            Out.writeUTF(areaCode);
            Out.writeUTF(bundle);
            Out.writeUTF(areaName);
            Out.writeBoolean(isStreaming);
            Out.writeInt(capacity);
            Out.writeInt(currentCount);
            Out.writeInt(defaultAreaCount);
            Out.writeInt(maxArea);
            Out.writeInt(maxPeople);
            return;
        }
    }
}

