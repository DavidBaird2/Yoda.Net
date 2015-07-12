
using System.Collections.Generic;
using Yoda.Net.Networking.Data.Room;
namespace Yoda.Net.Networking.Packet.Chat
{





    public class EnterAreaResultData : BaseEnterRoomResultData
    {
        public int type;
        public string code;

        public EnterAreaResultData()
        {
        }

        public override int packetId
        {
            get
            {
                return PacketId.ENTER_AREA_RESULT;
            }
        }

        override public string commandType
        {
            get
            {
                return AreaData.TYPE_AREA;
            }
        }

        override public void readData(PiggStream stream)
        {
            base.readData(stream);

            areaGameId = stream.readByte();
            var AreaGameDataBytes = stream.readInt();
            this.areaGameData = new byte[0];
            if (AreaGameDataBytes != 0)
            {
                this.areaGameData = stream.readBytes(AreaGameDataBytes);

            }
            isPiggDomeOpen = stream.readBoolean();
            switch (areaData.categoryCode)
            {
                case "user":
                case "club":
                case "secret":
                    {
                        break;
                    }
                default:
                    {
                        areaData.isPublished = stream.readBoolean();
                        areaData.zone = stream.readByte() + 1;
                        areaData.subCategoryCode = stream.readUTF();

                        areaData.bundleCode = stream.readUTF();
                        var taglist = stream.readInt();
                        areaData.tags = new Dictionary<int, int>(taglist);
                        var i = 0;
                        while (i < taglist)
                        {
                            areaData.tags[i] = stream.readByte();
                            i++;
                        }
                        if (areaData.isMatchingArea = stream.readBoolean())
                        {
                            areaData.gameCode = stream.readUTF();
                        }
                        taglist = stream.readInt();
                        defineTreasures = new List<DefineTreasure>(taglist);
                        if (taglist > 0)
                        {
                            treasureId = stream.readInt();
                            isTreasurePeriod = stream.readBoolean();
                            var num = 0;
                            while (num < taglist)
                            {
                                var treasure = new DefineTreasure();
                                treasure.treasureCode = stream.readUTF();
                                treasure.gotTreasure = stream.readBoolean();
                                treasure.isPeriod = stream.readBoolean();
                                defineTreasures.Add(treasure);
                                num++;
                            }
                        }
                        break;
                    }
            }
            return;
        }
        public override void writeData(PiggStream Out)
        {
            base.writeData(Out);
            Out.writeByte((byte)areaGameId);
            Out.writeInt((int)areaGameData.Length);
            if (areaGameData.Length != 0)
            {
                Out.writeBytes(new PiggStream(areaGameData), 0, (int)areaGameData.Length);
            }
            Out.writeBoolean(isPiggDomeOpen);
            switch (areaData.categoryCode)
            {
                case "user":
                case "club":
                case "secret":
                    {
                        break;
                    }
                default:
                    {
                        Out.writeBoolean(areaData.isPublished);
                        Out.writeByte((byte)(areaData.zone - 1));
                        Out.writeUTF(areaData.subCategoryCode);

                        Out.writeUTF(areaData.bundleCode);
                        Out.writeInt(areaData.tags.Count);
                        foreach (KeyValuePair<int, int> e in areaData.tags)
                        {
                            Out.writeByte((byte)e.Value);
                        }
                        Out.writeBoolean(areaData.isMatchingArea);
                        if (areaData.isMatchingArea)
                        {
                            Out.writeUTF(areaData.gameCode);
                        }
                        Out.writeInt(defineTreasures.Count);
                        if (defineTreasures.Count > 0)
                        {
                            Out.writeInt(treasureId);
                            Out.writeBoolean(isTreasurePeriod);
                            foreach (DefineTreasure item in this.defineTreasures)
                            {
                                Out.writeUTF(item.treasureCode);
                                Out.writeBoolean(item.gotTreasure);
                                Out.writeBoolean(item.isPeriod);
                            }
                        }
                        break;
                    }
            }
            Out.writeBoolean(false);
        }

        public List<DefineTreasure> defineTreasures { get; set; }

        public bool isTreasurePeriod { get; set; }

        public int treasureId { get; set; }
    }
}
