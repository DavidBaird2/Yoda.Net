using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using Yoda.Net.Networking.Data.Room;

namespace Yoda.Net.Networking.Data.Room
{
    public class FurnitureView
    {
        public DefineFurniture define;
        public PlaceFurniture place;
        public List<FurniturePartView> parts;
        public bool isMoving;
        //  private bool _isClickable;
        private bool[] _hasDir;
        private Object _data;

        public FurnitureView(DefineFurniture _arg1, PlaceFurniture _arg2, List<FurniturePartView> _arg3)
        {
            FurniturePartView _local5;
            this._hasDir = new bool[4] { false, false, false, false };
            //   super();
            this.define = _arg1;
            this.place = _arg2;
            this.parts = _arg3;
            this.isMoving = false;
            this._data = null;
            int _local4 = 0;
            while (_local4 < _arg3.Count)
            {
                _local5 = (FurniturePartView)_arg3[_local4];
                _local5.fview = this;
                _local4++;
            };
            //       this.changeDirection(_arg2.direction);
        }
        public Object data
        {
            get
            {
                return (this._data);
            }
        }
        public void clean()
        {
            int _local1;
            FurniturePartView _local2;
            if (this.parts != null)
            {
                _local1 = 0;
                while (_local1 < this.parts.Count)
                {
                    _local2 = (FurniturePartView)this.parts[_local1];
                    _local2.clean();
                    _local1++;
                };
                this.parts = null;
            };
            this.define = null;
            this.place = null;
            //  this._hasDir = null;
        }

        public int direction
        {
            get
            {
                return (this.place.direction);
            }
        }
        /*     public function getNextDirection():int{
                 var _local1:int = (this.place.direction + 1);
                 if (_local1 > 3)
                 {
                     _local1 = 0;
                 };
                 while (this._hasDir[_local1] == false)
                 {
                     _local1++;
                     if (_local1 > 3)
                     {
                         _local1 = 0;
                     };
                 };
                 return (_local1);
             }*/
        public FurniturePartView firstPart
        {
            get
            {
                if ((((this.parts == null)) || ((this.parts.Count == 0))))
                {
                    return (null);
                };
                return (FurniturePartView)(this.parts[0]);
            }
        }
        public string characterId
        {
            get
            {
                return (this.define.characterId);
            }
        }





        /*    public function clone():FurnitureView{
                var _local5:FurniturePartView;
                var _local6:FurniturePartView;
                var _local1:PlaceFurniture = this.place.clone();
                var _local2:Array = new Array(this.parts.length);
                var _local3:int;
                while (_local3 < this.parts.length)
                {
                    _local5 = this.parts[_local3];
                    _local6 = _local5.clone();
                    _local6.place = _local1;
                    _local2[_local3] = _local6;
                    _local3++;
                };
                var _local4:FurnitureView = new FurnitureView(this.define, _local1, _local2);
                return (_local4);
            }*/

    }
}
