namespace Yoda.Net.Networking.Packet.Info.Event
{
    using Yoda.Net.Networking.Packet.Data.Event;


    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventResultData : ICommandData
    {
        public EventData @event;
        public NoEventData noEvent;
        public bool success;
        public bool nazo1;
        public bool nazo2;
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
                if (this.@event == null)
                {
                    this.@event = new EventData();
                }
                this.@event.areaCategory = In.readUTF();
                this.@event.areaCode = In.readUTF();
                this.@event.areaTitle = In.readUTF();
                this.@event.category = In.readUTF();
                this.@event.title = In.readUTF();
                this.@event.description = In.readUTF();
                this.@event.createTime = In.readDouble();
                this.@event.numPeople = In.readInt();
                this.@event.ownerName = In.readUTF();
                this.@event.publishing = In.readByte();
                this.@event.image = In.readBoolean();
                if (this.@event.image)
                {
                    this.@event.ownerUserCode = In.readUTF();
                    this.@event.originPath = In.readUTF();
                    this.@event.thumbPath = In.readUTF();
                }
            }
            else
            {
                nazo1 = In.readBoolean();
                if (nazo1)
                {
                    this.noEvent = new NoEventData();
                    this.noEvent.ownerUserCode = In.readUTF();
                    this.noEvent.originPath = In.readUTF();
                    this.noEvent.thumbPath = In.readUTF();
                }
            }
            var nazo2 = In.readBoolean();
            if (nazo2)
            {
                if (this.@event != null)
                {
                    this.@event.warning = In.readBoolean();
                    this.@event.prohibition = In.readBoolean();
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
                if (this.@event == null)
                {
                    this.@event = new EventData();
                }
                Out.writeUTF(this.@event.areaCategory);
                Out.writeUTF(this.@event.areaCode);
                Out.writeUTF(this.@event.areaTitle);
                Out.writeUTF(this.@event.category);
                Out.writeUTF(this.@event.title);
                Out.writeUTF(this.@event.description);
                Out.writeDouble(this.@event.createTime);
                Out.writeInt(this.@event.numPeople);
                Out.writeUTF(this.@event.ownerName);
                Out.writeByte((byte)this.@event.publishing);
                Out.writeBoolean(this.@event.image);
                if (this.@event.image)
                {
                    Out.writeUTF(this.@event.ownerUserCode);
                    Out.writeUTF(this.@event.originPath);
                    Out.writeUTF(this.@event.thumbPath);
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


            Out.writeBoolean(nazo2);
            if (nazo2)
            {
                if (this.@event != null)
                {
                    Out.writeBoolean(this.@event.warning);
                    Out.writeBoolean(this.@event.prohibition);
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

