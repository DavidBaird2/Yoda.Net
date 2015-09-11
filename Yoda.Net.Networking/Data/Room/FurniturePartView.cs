using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yoda.Net.Networking.Astar;
using Yoda.Net.Networking.Data.Room;

namespace Yoda.Net.Networking.Data.Room
{
    public class FurniturePartView
    {
        public AstarNode node;
        public AstarNode nodeUnder;
        public PartData data;
        public FurnitureView fview;
        public Grid grid;
        public PlaceFurniture place;
        public DefineFurniture define;


        public FurniturePartView(PartData part, AstarNode node, AstarNode nodeUnder, DefineFurniture deffine, PlaceFurniture place)
        {
            this.data = part;
            this.node = node;
            if (node != null)
            {
                node.under = this;
            };
            this.nodeUnder = nodeUnder;
            if (nodeUnder != null)
            {
                nodeUnder.over = this;
            };
            this.define = deffine;
            this.place = place;

        }
        public void clean()
        {



            Grid _local1 = this.grid;
            if (_local1 != null)
            {
                _local1.removePart(this);
            };
            if (this.node != null)
            {
                this.node.under = null;
                this.node = null;
            };
            if (this.nodeUnder != null)
            {
                this.nodeUnder.over = null;
                this.nodeUnder = null;
            };
            this.data = null;
            this.fview = null;
            this.grid = null;
            this.place = null;
            this.define = null;

        }


        public int x
        {
            get
            {
                return this.place.x;
            }
        }
        public int y
        {
            get
            {
                return (this.place.y);
            }
        }
        public int z
        {
            get
            {
                return (this.place.z);
            }
        }


        public string characterId
        {
            get
            {
                return (this.define.characterId);
            }
        }
        public int sequence
        {
            get
            {
                return (this.place.sequence);
            }
        }
        /*   public function set direction(_arg1:int):void{
               var _local2:MovieClip = this._mcs[this._dir];
               var _local3:MovieClip = this._mcs[_arg1];
               if (_local3 != null)
               {
                   if (_local3.front)
                   {
                       this._iobj.addFront(_local3.front);
                       if (((_local2) && (_local2.front)))
                       {
                           this._iobj.remove(_local2.front);
                       };
                   } else
                   {
                       if (_local3.back)
                       {
                           this._iobj.addBack(_local3.back);
                           if (((_local2) && (_local2.back)))
                           {
                               this._iobj.remove(_local2.back);
                           };
                       };
                   };
                   this._dir = _arg1;
                   this._iobj.updateHitArea();
               };
           }*/
        /*   public function get commentStack():CommentBubbleStack{
               return (this._commentStack);
           }*/
    }
}
