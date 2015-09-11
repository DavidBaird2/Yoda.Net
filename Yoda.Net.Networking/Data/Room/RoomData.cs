using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;


namespace Yoda.Net.Networking.Data.Room
{
   public  class RoomData
    {
        public uint RoomId;
        public byte[] areaGameData;
        public bool hasLeftFootPrintToday;
        public bool isAdmin;
        public int numFootPrintToday;
        public DefineFurniture wall;
        public DefineFurniture floor;
        public List<DefinePet> definePets;
        public AreaData areaData;
        public int areaGameId;
        public List<PlacePet> placePets;
        public List<DefineFurniture> defineFurnitures;
        public List<PlaceActionItem> placeActionItems;
        public bool isUserRoomOwner;
        public List<PlaceFurniture> placeFurnitures;
        public DefineFurniture front;
        public DefineFurniture window;
        public int isPiggLifeAvalable;
        public List<PlaceAvatar> placeAvatars;
        public double serverTime;
        public List<DefineAvatar> defineAvatars;
        public RoomData()
        {
            
        }
    }
}
