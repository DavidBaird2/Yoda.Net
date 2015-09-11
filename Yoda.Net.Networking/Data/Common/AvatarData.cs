namespace Yoda.Net.Networking.Data.Common
{

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Data.Cosme;

    public class AvatarData
    {
        public string amebaId;
        public BodyColorData color = new BodyColorData();
        public List<string> conditions = new List<string>();
        public BodyItemData item = new BodyItemData();
        public string nickname;
        public string asUserId;
        public List<CosmeDressUpItemData> cosme;
        public BodyPartData part = new BodyPartData();
        public BodyPositionData position = new BodyPositionData();
        public string userCode;


        public void readData(PiggStream In)
        {
            CosmeDressUpItemData DressupItemData = null;
            userCode = In.readUTF();
            amebaId = In.readUTF();
            asUserId = In.readUTF();
            nickname = In.readUTF();
            part.readData(In,true);
            color.readData(In);
            position.readData(In);
            var total = In.readByte();
            var itemList = new List<string>(total);
            var count = 0;
            while (count < total)
            {

                itemList.Insert(count, In.readUTF());
                count++;
            }
            item.items = itemList;
            total = In.readByte();
            cosme = new List<CosmeDressUpItemData>(total);
            count = 0;
            while (count < total)
            {

                DressupItemData = new CosmeDressUpItemData();
                DressupItemData.readData(In);
                cosme.Insert(count, DressupItemData);
                count++;
            }
            total = In.readByte();
            conditions = new List<string>(total);
            count = 0;
            while (count < total)
            {

                conditions.Insert(count, In.readUTF());
                count++;
            }
            return;
        }
        public void reset()
        {
        }


        public void writeData(PiggStream Out)
        {
            CosmeDressUpItemData CDUID = null;
            Out.writeUTF(userCode);
            Out.writeUTF(amebaId);
            Out.writeUTF(asUserId);
            Out.writeUTF(nickname);
            part.writeData(Out, true);
            color.writeData(Out);
            position.writeData(Out);
            var totalNum = item.items.Count;
            Out.writeByte((Byte)totalNum);
            int count = 0;
            while (count < totalNum)
            {

                Out.writeUTF((string)item.items[count]);
                count++;
            }
            totalNum = cosme.Count;
            Out.writeByte((sbyte)totalNum);
            count = 0;
            while (count < totalNum)
            {

                CDUID = (CosmeDressUpItemData)cosme[count];
                CDUID.writeData(Out);

                count++;
            }
            totalNum = conditions.Count;
            Out.writeByte((byte)totalNum);
            count = 0;
            while (count < totalNum)
            {

                Out.writeUTF((string)conditions[count]);
                count++;
            }
            return;
        }
    }
}

