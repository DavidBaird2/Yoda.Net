
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yoda.Net.Networking.Data.Mannequin
{
    public class MannequinIdData
    {
        public MannequinIdData(string placeAreaCode = null, int sequence = -1, string furnitureId = null, int mode = -1, string operationId = "")
        {

            this.placeAreaCode = placeAreaCode;
            this.sequence = sequence;
            this.furnitureId = furnitureId;
            this.mode = mode;
            this.operationId = operationId;
        }

        public string placeAreaCode;

        public int sequence;

        public string furnitureId;

        public string operationId;

        public int mode;

        public void readData(PiggStream In)
        {
            this.placeAreaCode = In.readUTF();
            this.sequence = In.readInt();
            this.furnitureId = In.readUTF();
        }

        public void readAreaCodeAndSequenceData(PiggStream stream)
        {
            this.placeAreaCode = stream.readUTF();
            this.sequence = stream.readInt();
        }
        public void writeAreaCodeAndSequenceData(PiggStream Out)
        {
            Out.writeUTF(placeAreaCode);
            Out.writeInt(sequence);
        }

        public void writeData(PiggStream Out)
        {
            Out.writeUTF(this.placeAreaCode);
            Out.writeInt(this.sequence);
            Out.writeUTF(this.furnitureId);
        }

        public bool isEqual(MannequinIdData Stream)
        {
            if (Stream == null)
            {
                return false;
            }
            if (this.sequence == Stream.sequence && this.placeAreaCode == Stream.placeAreaCode)
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

