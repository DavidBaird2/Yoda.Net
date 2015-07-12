﻿namespace Yoda.Net.Networking.Packet.Chat
{


    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Yoda.Net.Networking.Data.Common;
    using Yoda.Net.Networking.Data.Room;
    
    
    
    
    
    

    public class BaseEnterRoomResultData : ICommandData
    {
        public Yoda.Net.Networking.Data.Room.AreaData areaData;
        public List<PlaceFurniture> placeFurnitures;
        public List<DefineFurniture> defineFurnitures;
        public List<PlaceAvatar> placeAvatars;
        public List<DefineAvatar> defineAvatars;
        public List<PlacePet> placePets;
        public List<DefinePet> definePets;
        public List<PlaceActionItem> placeActionItems;
        public int isAdmin;
        public bool isChannelActor;
        public double serverTime;
        public int areaGameId;
        public byte[] areaGameData;
        public int isPiggLifeAvailable = 1;
        public int isPiggIslandAvailable = 1;
        public int isPiggSurvivalGameAvailable = 1;
        public int isPiggCafeAvailable = 1;
        public int isPiggWorldAvailable = 1;
        public bool isCheckPlaceGift;
        public bool isPiggDomeOpen;
        public bool isAllowRoomChange;
        public bool isRefleshedCosmeItem;
        public ShuffleGoOutData shuffleGoOutData;
        public virtual int packetId
        {
            get
            {
                return 0;
            }
        }
        public virtual string commandType
        {
            get
            {
                return "base";
            }
        }

        protected virtual void readCodeData(PiggStream stream)
        {
            this.areaData.frontCode = stream.readUTF();
            this.areaData.wallCode = stream.readUTF();
            this.areaData.floorCode = stream.readUTF();
            this.areaData.windowCode = stream.readUTF();
            return;
        }
        protected virtual void writeCodeData(PiggStream stream)
        {
            stream.writeUTF(this.areaData.frontCode);
            stream.writeUTF(this.areaData.wallCode);
            stream.writeUTF(this.areaData.floorCode);
            stream.writeUTF(this.areaData.windowCode);
            return;
        }

        public virtual void readData(PiggStream In)
        {
            PlaceFurniture furniture = null;
            int n;
            int num = 0;
            DefineFurniture furniture2 = null;
            int index = 0;
            PlaceAvatar avatar = null;
            DefineAvatar avatar2 = null;
            AvatarData data = null;
            PartData data2 = null;
            DefinePet pet = null;
            PlacePet pet2 = null;
            PlaceActionItem item = null;
            this.areaData = new Yoda.Net.Networking.Data.Room.AreaData();
            this.areaData.categoryCode = In.readUTF();
            this.areaData.categoryName = In.readUTF();
            this.areaData.areaCode = In.readUTF();
            this.areaData.areaName = In.readUTF();
            readCodeData(In);
            this.areaData.sizeX = In.readShort();
            this.areaData.sizeY = In.readShort();


            int capacity = In.readInt();
            this.placeFurnitures = new List<PlaceFurniture>();
            for (n = 0; n < capacity; n++)
            {
                furniture = new PlaceFurniture
                {
                    characterId = In.readUTF(),
                    sequence = In.readInt(),
                    x = In.readShort(),
                    y = In.readShort(),
                    z = In.readShort(),
                    direction = In.readByte(),
                    ownerId = In.readUTF()
                };
                this.placeFurnitures.Add(furniture);
            }
            capacity = In.readInt();
            this.defineFurnitures = new List<DefineFurniture>();
            for (n = 0; n < capacity; n++)
            {
                num = In.readShort();
                furniture2 = new DefineFurniture
                {
                    characterId = In.readUTF(),
                    type = (int)In.readByte(),
                    category = In.readUTF(),
                    name = In.readUTF(),
                    description = In.readUTF(),
                    actionCode = In.readUTF()
                };
                for (index = 1; index <= num; index++)
                {
                    furniture2.parts.Add(this.readPart(In, index));
                }
                this.defineFurnitures.Add(furniture2);
            }
            capacity = In.readInt();
            this.placeAvatars = new List<PlaceAvatar>();
            this.defineAvatars = new List<DefineAvatar>();
            for (n = 0; n < capacity; n++)
            {
                avatar = new PlaceAvatar();
                avatar2 = new DefineAvatar();
                data = new AvatarData();
                data.readData(In);
                avatar2.characterId = data.userCode;
                avatar2.name = data.amebaId;
                avatar2.data = data;
                avatar.characterId = avatar2.characterId;
                avatar.x = In.readShort();
                avatar.y = In.readShort();
                avatar.z = In.readShort();
                avatar.direction = In.readByte();
                avatar.status = In.readByte();
                avatar.tired = In.readByte();
                avatar.mode = In.readByte();
                data2 = new PartData
                {
                    height = 0x60
                };
                avatar2.part = data2;
                this.placeAvatars.Insert(n, avatar);
                this.defineAvatars.Insert(n, avatar2);
            }
            capacity = In.readInt();
            this.placePets = new List<PlacePet>();
            this.definePets = new List<DefinePet>();
            for (n = 0; n < capacity; n++)
            {
                pet = new DefinePet();
                pet.data.readData(In);
                this.definePets.Insert(n, pet);
                pet2 = new PlacePet
                {
                    petId = pet.petId(),
                    x = In.readShort(),
                    y = In.readShort(),
                    z = In.readShort(),
                    direction = In.readByte(),
                    sleeping = In.readBoolean()
                };
                this.placePets.Insert(n, pet2);
            }
            capacity = In.readInt();
            this.placeActionItems = new List<PlaceActionItem>();
            for (n = 0; n < capacity; n++)
            {
                item = new PlaceActionItem
                {
                    itemType = In.readUTF(),
                    itemCode = In.readUTF(),
                    ownerCode = In.readUTF(),
                    sequence = In.readInt(),
                    actionItemType = In.readByte(),
                    x = In.readShort(),
                    y = In.readShort(),
                    z = In.readShort()
                };
                this.placeActionItems.Insert(n, item);
            }
            capacity = In.readInt();
            for (n = 0; n < capacity; n++)
            {
                item = new PlaceActionItem
                {
                    itemCode = In.readUTF(),
                    itemType = In.readUTF(),
                    sequence = In.readInt(),
                    ownerCode = In.readUTF(),
                    actionItemType = 2,
                    x = In.readShort(),
                    y = In.readShort(),
                    z = In.readShort()
                };
                this.placeActionItems.Add(item);
            }
            this.isAdmin = In.readInt();
            this.isChannelActor = In.readBoolean();

            this.serverTime = In.readDouble();
            this.isRefleshedCosmeItem = In.readBoolean();
            this.isAllowRoomChange = In.readBoolean();
            var friendCount = In.readByte();
            capacity = 0;
            while (capacity < friendCount)
            {

               var code = In.readUTF();
               defineAvatars.Find(i => i.characterId == code).friend = true;
                capacity++;
            }
         
            int postion = (int)In.position;
            In.position = 0;
         //   Engine.Log(BytesConvert.ToHexString(In.readBytes(postion)));
            In.position = postion;

        }

        private PartData readPart(PiggStream In, int Index)
        {
            return new PartData { height = In.readInt(), attachable = In.readBoolean(), sittable = In.readBoolean(), walkable = In.readBoolean(), wall = In.readByte(), attachDirection = In.readByte(), index = Index, rx = In.readByte(), ry = In.readByte() };
        }
        private void WritePart(PiggStream Out, PartData Part)
        {
            Out.writeInt(Part.height);
            Out.writeBoolean(Part.attachable);
            Out.writeBoolean(Part.sittable);
            Out.writeBoolean(Part.walkable);
            Out.writeByte(Part.wall);
            Out.writeByte((byte)Part.attachDirection);
            Out.writeByte((byte)Part.rx);
            Out.writeByte((byte)Part.ry);
        }
        public virtual void writeData(PiggStream Out)
        {
            PlaceAvatar avatar = null;
            DefineAvatar avatar2 = null;
            AvatarData data = null;
            DefinePet pet = null;
            PlacePet pet2 = null;
            int num2;
            Out.writeUTF(this.areaData.categoryCode);
            Out.writeUTF(this.areaData.categoryName);
            Out.writeUTF(this.areaData.areaCode);
            Out.writeUTF(this.areaData.areaName);
            writeCodeData(Out);
            Out.writeShort((short)this.areaData.sizeX);
            Out.writeShort((short)this.areaData.sizeY);


            int num3 = this.placeFurnitures.Count;
            Out.writeInt(num3);
            foreach (PlaceFurniture furniture in this.placeFurnitures)
            {
                Out.writeUTF(furniture.characterId);
                Out.writeInt(furniture.sequence);
                Out.writeShort(furniture.x);
                Out.writeShort(furniture.y);
                Out.writeShort(furniture.z);
                Out.writeByte((byte)furniture.direction);
                Out.writeUTF(furniture.ownerId);
            }
            num3 = this.defineFurnitures.Count;
            Out.writeInt(num3);
            foreach (DefineFurniture furniture2 in this.defineFurnitures)
            {
                Out.writeShort((short)furniture2.parts.Count);
                Out.writeUTF(furniture2.characterId);
                Out.writeByte((byte)furniture2.type);
                Out.writeUTF(furniture2.category);
                Out.writeUTF(furniture2.name);
                Out.writeUTF(furniture2.description);
                Out.writeUTF(furniture2.actionCode);
                foreach (PartData data2 in furniture2.parts)
                {
                    this.WritePart(Out, data2);
                }
            }
            num3 = this.placeAvatars.Count;
            Out.writeInt(num3);
            for (num2 = 0; num2 < num3; num2++)
            {
                avatar = (PlaceAvatar)this.placeAvatars[num2];
                avatar2 = (DefineAvatar)this.defineAvatars[num2];
                data = new AvatarData
                {
                    userCode = avatar2.characterId,
                    amebaId = avatar2.name
                };
                avatar2.data.writeData(Out);
                Out.writeShort(avatar.x);
                Out.writeShort(avatar.y);
                Out.writeShort(avatar.z);
                Out.writeByte((byte)avatar.direction);
                Out.writeByte((byte)avatar.status);
                Out.writeByte((byte)avatar.tired);
                Out.writeByte((byte)avatar.mode);
            }
            num3 = this.placePets.Count;
            Out.writeInt(num3);
            for (num2 = 0; num2 < num3; num2++)
            {
                pet = (DefinePet)this.definePets[num2];
                pet.data.writeData(Out);
                pet2 = (PlacePet)this.placePets[num2];
                Out.writeShort(pet2.x);
                Out.writeShort(pet2.y);
                Out.writeShort(pet2.z);
                Out.writeByte((byte)pet2.direction);
                Out.writeBoolean(pet2.sleeping);
            }
            num3 = this.placeActionItems.Count;
            Out.writeInt(num3);
            num2 = 0;
            foreach (PlaceActionItem item in this.placeActionItems)
            {
                Out.writeUTF(item.itemType);
                Out.writeUTF(item.itemCode);
                Out.writeUTF(item.ownerCode);
                Out.writeInt(item.sequence);
                Out.writeByte((byte)item.actionItemType);
                Out.writeShort(item.x);
                Out.writeShort(item.y);
                Out.writeShort(item.z);
            }
            Out.writeInt(0);
            Out.writeInt(isAdmin);

            Out.writeBoolean(isChannelActor);
            Out.writeDouble(this.serverTime);

            Out.writeBoolean(isRefleshedCosmeItem);

            Out.writeBoolean(isAllowRoomChange);
            //フレンド
            Out.writeByte((byte)this.defineAvatars.FindAll(i=>i.friend).Count);
            foreach(DefineAvatar av in this.defineAvatars)
            {
                if(av.friend)
                Out.writeUTF(av.characterId);
            }

            

            int postion = (int)Out.position;
            Out.position = 0;
           // Engine.Log(BytesConvert.ToHexString(Out.readBytes(postion)));
            Out.position = postion;
           

        }


    }
}

