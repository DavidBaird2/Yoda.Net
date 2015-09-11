using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Astar;
using Yoda.Net.Networking.Data.Room;
using Yoda.Net.Networking.Packet.Chat;

namespace Yoda.Net.Networking.Data.Room
{
   public  class RoomAvatarView
    {

        public DefineAvatar define { get; set; }
     //   private AstarNode _currentNode;
       /*
        public AstarNode currentNode
        {
            get { return _currentNode; }
        }*/
        public AstarNode targetNode;

        public PlaceAvatar place { get; set; }
        public  RoomAvatarView(DefineAvatar param1, PlaceAvatar param2)
        {
            this.define = param1;
            this.place = param2;
            return;
        }

    }
}
