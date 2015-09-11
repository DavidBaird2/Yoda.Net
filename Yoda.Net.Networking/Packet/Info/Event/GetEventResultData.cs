namespace Yoda.Net.Networking.Packet.Info.Event
{
    using Yoda.Net.Networking.Packet.Data.Event;


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventResultData : ICommandData
    {
        public EventData _event;
        public NoEventData noEvent;
        public bool success;
        public bool nazo1;
        public bool hasWarning;
        public int packetId
        {
            get
            {
                return PacketId.GET_NOTICE_BOARD_MESSAGE_RESULT;
            }
        }

        public void readData(PiggStream In)
        {
            this.success = In.readBoolean();
            if (this.success)
            {
                if (this._event == null)
                {
                    this._event = new EventData();
                }
                this._event.areaCategory = In.readUTF();
                this._event.areaCode = In.readUTF();
                this._event.areaTitle = In.readUTF();
                this._event.category = In.readUTF();
                this._event.title = In.readUTF();
                this._event.description = In.readUTF();
                this._event.createTime = In.readTime();
                this._event.numPeople = In.readInt();
                this._event.ownerName = In.readUTF();
                this._event.publishing = In.readByte();
                this._event.image = In.readBoolean();
                if (this._event.image)
                {
                    this._event.ownerUserCode = In.readUTF();
                    this._event.originPath = In.readUTF();
                    this._event.thumbPath = In.readUTF();
                }
            }
            else
            {
        
                if (In.readBoolean())
                {
                    this.noEvent = new NoEventData();
                    this.noEvent.ownerUserCode = In.readUTF();
                    this.noEvent.originPath = In.readUTF();
                    this.noEvent.thumbPath = In.readUTF();
                }
            }


             hasWarning = In.readBoolean();
            if (hasWarning)
            {
                if (this._event != null)
                {
                    this._event.warning = In.readBoolean();
                    this._event.prohibition = In.readBoolean();
                }
                else
                {
                    if (this.noEvent == null)
                    {
                        this.noEvent = new NoEventData();
                    }
                    this.noEvent.warning = In.readBoolean();
                    this.noEvent.prohibition = In.readBoolean();
                }
            }
            return;

        }

        public void writeData(PiggStream Out)
        {

            Out.writeBoolean(this.success);
            if (this.success)
            {
                if (this._event == null)
                {
                    this._event = new EventData();
                }
                Out.writeUTF(this._event.areaCategory);
                Out.writeUTF(this._event.areaCode);
                Out.writeUTF(this._event.areaTitle);
                Out.writeUTF(this._event.category);
                Out.writeUTF(this._event.title);
                Out.writeUTF(this._event.description);
                Out.writeDate(this._event.createTime);
                Out.writeInt(this._event.numPeople);
                Out.writeUTF(this._event.ownerName);
                Out.writeByte((byte)this._event.publishing);
                Out.writeBoolean(this._event.image);
                if (this._event.image)
                {
                    Out.writeUTF(this._event.ownerUserCode);
                    Out.writeUTF(this._event.originPath);
                    Out.writeUTF(this._event.thumbPath);
                }
            }
            else
            {
                Out.writeBoolean(nazo1);
                if (nazo1)
                {
                    this.noEvent = new NoEventData();
                    Out.writeUTF(this.noEvent.ownerUserCode);
                    Out.writeUTF(this.noEvent.originPath);
                    Out.writeUTF(this.noEvent.thumbPath);
                }
            }


            Out.writeBoolean(hasWarning);
            if (hasWarning)
            {
                if (this._event != null)
                {
                    Out.writeBoolean(this._event.warning);
                    Out.writeBoolean(this._event.prohibition);
                }
                else
                {
                    if (this.noEvent == null)
                    {
                        this.noEvent = new NoEventData();
                    }
                    Out.writeBoolean(this.noEvent.warning);
                    Out.writeBoolean(this.noEvent.prohibition);
                }
            }

            return;
        }
    }
}

