namespace Yoda.Net.Networking.Packet.Info.Event
{
    using Yoda.Net.Networking.Packet.Data.Event;
    
    
    using System;
    using System.Collections;
    using Yoda.Net.Networking.Data.Event;

    public class GetEventResultData : IPacket
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
    
        public void readData(AmebaStream param1)
        {
            this.success = param1.readBoolean();
            if (this.success)
            {
                if (this.@event == null)
                {
                    this.@event = new EventData();
                }
                this.@event.areaCategory = param1.readUTF();
                this.@event.areaCode = param1.readUTF();
                this.@event.areaTitle = param1.readUTF();
                this.@event.category = param1.readUTF();
                this.@event.title = param1.readUTF();
                this.@event.description = param1.readUTF();
                this.@event.createTime = param1.readDouble();
                this.@event.numPeople = param1.readInt();
                this.@event.ownerName = param1.readUTF();
                this.@event.publishing = param1.readByte();
                this.@event.image = param1.readBoolean();
                if (this.@event.image)
                {
                    this.@event.ownerUserCode = param1.readUTF();
                    this.@event.originPath = param1.readUTF();
                    this.@event.thumbPath = param1.readUTF();
                }
            }
            else
            {
                nazo1 = param1.readBoolean();
                if (nazo1)
                {
                    this.noEvent = new NoEventData();
                    this.noEvent.ownerUserCode = param1.readUTF();
                    this.noEvent.originPath = param1.readUTF();
                    this.noEvent.thumbPath = param1.readUTF();
                }
            }
            var nazo2 = param1.readBoolean();
            if (nazo2)
            {
                if (this.@event != null)
                {
                    this.@event.warning = param1.readBoolean();
                    this.@event.prohibition = param1.readBoolean();
                }
                else
                {
                    if (this.noEvent == null)
                    {
                        this.noEvent = new NoEventData();
                    }
                    this.noEvent.warning = param1.readBoolean();
                    this.noEvent.prohibition = param1.readBoolean();
                }
            }
            return;
           
        }

        public void writeData(AmebaStream Out)
        {
     
           Out.writeBoolean( this.success );
            if (this.success)
            {
                if (this.@event == null)
                {
                    this.@event = new EventData();
                }
              Out.writeUTF(  this.@event.areaCategory);
                Out.writeUTF(   this.@event.areaCode );
                Out.writeUTF(   this.@event.areaTitle );
                Out.writeUTF(   this.@event.category );
                Out.writeUTF(   this.@event.title );
                Out.writeUTF(   this.@event.description );
              Out.writeDouble(  this.@event.createTime);
              Out.writeInt(  this.@event.numPeople);
               Out.writeUTF(    this.@event.ownerName );
              Out.writeByte( (byte) this.@event.publishing );
              Out.writeBoolean(  this.@event.image );
                if (this.@event.image)
                {
                  Out.writeUTF(     this.@event.ownerUserCode);
                  Out.writeUTF(     this.@event.originPath );
                   Out.writeUTF(    this.@event.thumbPath );
                }
            }
            else
            {
                Out.writeBoolean(nazo1);
                if (nazo1)
                {
                    this.noEvent = new NoEventData();
                    Out.writeUTF(   this.noEvent.ownerUserCode);
                    Out.writeUTF(   this.noEvent.originPath);
                    Out.writeUTF(   this.noEvent.thumbPath);
                }
            }

    
            Out.writeBoolean(nazo2);
            if (nazo2)
            {
                if (this.@event != null)
                {
                    Out.writeBoolean(    this.@event.warning);
                     Out.writeBoolean(  this.@event.prohibition);
                }
                else
                {
                    if (this.noEvent == null)
                    {
                        this.noEvent = new NoEventData();
                    }
                     Out.writeBoolean(   this.noEvent.warning);
                     Out.writeBoolean(   this.noEvent.prohibition );
                }
            }
        
            return;
        }
    }
}

