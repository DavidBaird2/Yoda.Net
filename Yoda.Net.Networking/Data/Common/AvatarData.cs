namespace Yoda.Net.Networking.Data.Common
{

    using System;
    using System.Collections;
    using Yoda.Net.Networking;
    using Yoda.Net.Networking.Data.Cosme;

    public class AvatarData
    {
        public string amebaId;
        public BodyColorData color = new BodyColorData();
        public ArrayList conditions;
        public BodyItemData item = new BodyItemData();
        public string nickname;
        public string asUserId;
        public ArrayList cosme;
        public BodyPartData part = new BodyPartData();
        public BodyPositionData position = new BodyPositionData();
        public string userCode;
        public bool getComsePartUse(string param1)
        {
            int _loc_2 = 0;
            int _loc_3 = 0;
            int _loc_4 = -1;
            switch (param1)
            {
                case Category.COSME_EYELINE:
                    {
                        _loc_2 = 12;
                        _loc_3 = 35;
                        break;
                    }
                case Category.COSME_EYELASH:
                case Category.COSME_EYESHADOW:
                    {
                        _loc_2 = 0;
                        _loc_3 = 36;
                        break;
                    }
                case Category.COSME_CONTACT:
                    {
                        _loc_2 = 0;
                        _loc_3 = 35;
                        break;
                    }
                case Category.COSME_MOUTH:
                    {
                        _loc_2 = 0;
                        _loc_3 = 20;
                        break;
                    }
                default:
                    {
                        return true;
                    }
            }
            switch (param1)
            {
                case Category.COSME_EYELASH:
                case Category.COSME_CONTACT:
                case Category.COSME_EYELINE:
                case Category.COSME_EYESHADOW:
                    {
                        _loc_4 = part.eye;
                        break;
                    }
                case Category.COSME_MOUTH:
                    {
                        _loc_4 = part.mouth;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (_loc_2 <= _loc_4 && _loc_4 < _loc_3)
            {
                return true;
            }
            return false;
        }
        public bool getCosmeUse()
        {
            CosmeDressUpItemData _loc_3 = null;
            bool _loc_1 = true;
            int _loc_2 = 0;
            while (_loc_2 < cosme.Count)
            {

                _loc_3 = cosme[_loc_2] as CosmeDressUpItemData;
                if (getComsePartUse(_loc_3.type) == false)
                {
                    _loc_1 = false;
                    break;
                }
                _loc_2++;
            }
            return _loc_1;
        }

        public void readData(AmebaStream In)
        {
            CosmeDressUpItemData _loc_5 = null;
            userCode = In.readUTF();
            amebaId = In.readUTF();
            asUserId = In.readUTF();
            nickname = In.readUTF();
            part.gender = In.readByte();
            part.readData(In);
            color.readData(In);
            position.readData(In);
            var _loc_2 = In.readByte();
            var _loc_3 = new ArrayList(_loc_2);
            var _loc_4 = 0;
            while (_loc_4 < _loc_2)
            {

                _loc_3.Insert(_loc_4, In.readUTF());
                _loc_4++;
            }
            item.items = _loc_3;
            _loc_2 = In.readByte();
            cosme = new ArrayList(_loc_2);
            _loc_4 = 0;
            while (_loc_4 < _loc_2)
            {

                _loc_5 = new CosmeDressUpItemData();
                _loc_5.readData(In);
                cosme.Insert(_loc_4, _loc_5);
                _loc_4++;
            }
            _loc_2 = In.readByte();
            conditions = new ArrayList(_loc_2);
            _loc_4 = 0;
            while (_loc_4 < _loc_2)
            {

                conditions.Insert(_loc_4, In.readUTF());
                _loc_4++;
            }
            return;
        }
        public void reset()
        {
        }


        public void writeData(AmebaStream Out)
        {
            CosmeDressUpItemData _loc_4 = null;
            Out.writeUTF(userCode);
            Out.writeUTF(amebaId);
            Out.writeUTF(nickname);
            part.writeData(Out, true);
            color.writeData(Out);
            position.writeData(Out);
            var _loc_2 = item.items.Count;
            Out.writeByte((Byte)_loc_2);
            int _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {

                Out.writeUTF((string)item.items[_loc_3]);
                _loc_3++;
            }
            _loc_2 = cosme.Count;
            Out.writeByte((byte)_loc_2);
            _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {

                _loc_4 = (CosmeDressUpItemData)cosme[_loc_3];
                Out.writeUTF(_loc_4.itemCode);
                Out.writeUTF(_loc_4.type);
                _loc_3++;
            }
            _loc_2 = conditions.Count;
            Out.writeByte((byte)_loc_2);
            _loc_3 = 0;
            while (_loc_3 < _loc_2)
            {

                Out.writeUTF((string)conditions[_loc_3]);
                _loc_3++;
            }
            return;
        }
    }
}

