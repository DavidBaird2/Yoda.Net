
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinIdData
    {
        public MannequinIdData(string param1 = null, int param2 = -1, string param3 = null, int param4 = -1, string param5 = "")
        {

            this.placeAreaCode = param1;
            this.sequence = param2;
            this.furnitureId = param3;
            this.mode = param4;
            this.operationId = param5;
        }

        public string placeAreaCode;

        public int sequence;

        public string furnitureId;

        public string operationId;

        public int mode;

        public void readData(AmebaStream param1)
        {
            this.placeAreaCode = param1.readUTF();
            this.sequence = param1.readInt();
            this.furnitureId = param1.readUTF();
        }

        public void readAreaCodeAndSequenceData(AmebaStream param1)
        {
            this.placeAreaCode = param1.readUTF();
            this.sequence = param1.readInt();
        }

        public void writeData(AmebaStream param1)
        {
            param1.writeUTF(this.placeAreaCode);
            param1.writeInt(this.sequence);
            param1.writeUTF(this.furnitureId);
        }

        public bool isEqual(MannequinIdData param1)
        {
            if (param1 == null)
            {
                return false;
            }
            if (this.sequence == param1.sequence && this.placeAreaCode == param1.placeAreaCode)
            {
                return true;
            }
            return false;
        }

        public MannequinIdData clone()
        {
            return new MannequinIdData(this.placeAreaCode, this.sequence, this.furnitureId, this.mode, this.operationId);
        }

        public string toString()
        {
            return "area=" + this.placeAreaCode + "\nsequence=" + this.sequence + "\nfurnitureId=" + this.furnitureId + "\noperationId=" + this.operationId;
        }
    }
}

