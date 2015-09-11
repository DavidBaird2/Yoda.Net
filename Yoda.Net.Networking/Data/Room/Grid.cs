using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Yoda.Net.Networking.Astar;

namespace Yoda.Net.Networking.Data.Room
{
    public class Grid
    {
        public int index;
        public int x;
        public int y;
        //グリッド上にあるnode一覧、低い順に格納
        private List<AstarNode> nodes;
        
        //周りにあるグリッド
        public List<Grid> nears;
        
        //
        public List<FurniturePartView> parts;
        private bool isStart;
        public Grid(int x, int y, int index)
        {
            this.nodes = new List<AstarNode> { new AstarNode(x, y, 0) };
            this.nears = new List<Grid>();
            this.index = index;
            this.x = x;
            this.y = y;
            this.isStart = false;
            return;
        }

        public void setStart(bool param1)
        {
            this.isStart = param1;
            return;
        }

        public void clean()
        {
            this.nodes = null;
            this.nears = null;
            this.parts = null;
            return;
        }

        public AstarNode floorNode
        {
            get
            {
                return (AstarNode)this.nodes[0];
            }
        }

        public void addPart(FurniturePartView param1)
        {
            if (this.parts == null)
            {
                this.parts = new List<FurniturePartView>();
            }

            this.parts.Add(param1);

            var reqSort = false;
            if (param1.nodeUnder != null)
            {
                if (this.nodes.IndexOf(param1.nodeUnder) < 0)
                {
                    this.nodes.Add(param1.nodeUnder);
                    reqSort = true;
                }
            }
            if (param1.node != null)
            {
                this.nodes.Add(param1.node);
                reqSort = true;
            }
            if (reqSort)
            {
                this.nodes.Sort(new compareNode());
            }
            param1.grid = this;
            return;
        }

        public void removePart(FurniturePartView param1)
        {
            if (this.parts == null)
            {
                return;
            }
            var _loc_2 = this.parts.IndexOf(param1);
            if (_loc_2 >= 0)
            {
                // this._parts.splice(_loc_2, 1);
                this.parts.RemoveAt(_loc_2);
                param1.grid = null;
            }
            return;
        }

        public void addNode(AstarNode param1)
        {
            if (param1 != null)
            {
                this.nodes.Add(param1);
                this.nodes.Sort(new compareNode());
            }
            return;
        }

        public void removeNode(AstarNode param1)
        {
            int _loc_2 = 0;
            if (param1 != null)
            {
                param1.disconnectAll();
                _loc_2 = this.nodes.IndexOf(param1);
                if (_loc_2 >= 0)
                {
                    //     this._nodes.splice(_loc_2, 1);

                    this.nodes.RemoveAt(_loc_2);
                }
            }
            return;
        }

        public bool hasFurniture(FurniturePartView param1)
        {
            FurniturePartView _loc_3 = null;
            if (this.parts == null)
            {
                return false;
            }
            int _loc_2 = 0;
            while (_loc_2 < this.parts.Count)
            {

                _loc_3 = (FurniturePartView)this.parts[_loc_2];
                if (_loc_3.fview.place.sequence == param1.fview.place.sequence)
                {
                    return true;
                }
                _loc_2++;
            }
            return false;
        }

        public bool isAddablePart(int param1, int param2, int param3)
        {
            FurniturePartView _loc_7 = null;
            int _loc_8 = 0;
            int _loc_9 = 0;
            var _loc_4 = param1 + param2;
            if (this.isStart && param1 < 160)
            {
                return false;
            }
            var _loc_5 = this.findNode(param1);
            if (this.findNode(param1) != null)
            {
                if (_loc_5.hasPeople)
                {
                    return false;
                }
            }
            if (this.parts == null)
            {
                return true;
            }
            int _loc_6 = 0;
            while (_loc_6 < this.parts.Count)
            {

                _loc_7 = (FurniturePartView)this.parts[_loc_6];
                if (_loc_7.fview.place.sequence != param3)
                {
                    _loc_8 = _loc_7.place.z;
                    _loc_9 = _loc_7.data.height;
                    if (param1 == _loc_8)
                    {
                        return false;
                    }
                    if (param1 < _loc_8 && _loc_4 > _loc_8)
                    {
                        return false;
                    }
                    if (param1 > _loc_8 && _loc_8 + _loc_9 > param1)
                    {
                        return false;
                    }
                }
                _loc_6++;
            }
            return true;
        }

        public FurniturePartView findPartBySequence(int param1)
        {
            FurniturePartView _loc_3 = null;
            if (this.parts == null)
            {
                return null;
            }
            int _loc_2 = 0;
            while (_loc_2 < this.parts.Count)
            {

                _loc_3 = (FurniturePartView)this.parts[_loc_2];
                if (_loc_3.place.sequence == param1)
                {
                    return _loc_3;
                }
                _loc_2++;
            }
            return null;
        }

        public void addNear(Grid param1)
        {
            if (param1 == this)
            {
                return;
            }
            if (this.nears.IndexOf(param1) < 0)
            {
                this.nears.Add(param1);
            }
            return;
        }

        public AstarNode findNode(int z)
        {
            AstarNode node = null;
            int i = 0;
            while (i < this.nodes.Count)
            {

                node = (AstarNode)this.nodes[i];
                if (node.z == z)
                {
                    return node;
                }
                if (z < node.z)
                {
                    return null;
                }
                i++;
            }
            return null;
        }

        public AstarNode findHighestNode()
        {
            return (AstarNode)this.nodes[(this.nodes.Count - 1)];
        }

        public void connectGrid(Grid targetGrid, bool hasInitialize)
        {
            if (targetGrid == null)
            {
                return;
            }
            var targetGridNodeCount = targetGrid.nodes;
            if (hasInitialize)
            {
                this.addNear(targetGrid);
                targetGrid.addNear(this);
            }
            var total = this.nodes.Count - 1;
            int i = 0;
            while (i <= total)
            {

                AstarNode thisProcessNode = (AstarNode)this.nodes[i];

                if (i < total)
                {
                    AstarNode thisNextNode = (AstarNode)this.nodes[(i + 1)];
                    if (thisNextNode.z - thisProcessNode.z <= 96/* RoomAvatarView.AVATAR_MAX_HEIGHT*/)
                    {
                        //高さがピグより低い場合
                        i++;
                        continue;
                    }
                }
                int targetTotal = targetGridNodeCount.Count - 1;
                int i2 = 0;
                while (i2 <= targetTotal)
                {

                    AstarNode targetProcessNode = (AstarNode)targetGridNodeCount[i2];
                    int thisz = thisProcessNode.z;
                    int targetz = targetProcessNode.z;
                    int jumpdifference = Math.Abs(thisz - targetz);
                    if (jumpdifference <= 50/*RoomAvatarView.AVATAR_MAX_JUMP*/)　//乗り越えられる高さの場合
                    {
                    
                        if (i2 < targetTotal)
                        {
                            AstarNode _loc_15 = (AstarNode)targetGridNodeCount[(i2 + 1)];
                           int _loc_16 = _loc_15.z - targetProcessNode.z;
                            if (_loc_16 >= 96/*RoomAvatarView.AVATAR_MAX_HEIGHT*/) //ピグの通れる高さがある場合
                            {
                                if (this.checkWall(thisProcessNode, targetProcessNode))
                                {
                                    thisProcessNode.connect(targetProcessNode);
                                }
                            }
                        }
                        else if (this.checkWall(thisProcessNode, targetProcessNode))
                        {
                            thisProcessNode.connect(targetProcessNode);
                        }
                    }


                    i2++;
                }
                i++;
            }
            return;
        }

        public void reconnect()
        {
            AstarNode _loc_2 = null;
            Grid _loc_3 = null;
            int _loc_1 = 0;
            while (_loc_1 < this.nodes.Count)
            {

                _loc_2 = (AstarNode)this.nodes[_loc_1];
                _loc_2.disconnectAll();
                _loc_1++;
            }
            _loc_1 = 0;
            while (_loc_1 < this.nears.Count)
            {

                _loc_3 = (Grid)this.nears[_loc_1];
                this.connectGrid(_loc_3, false);
                _loc_1++;
            }
            return;
        }

        private bool checkWall(AstarNode first, AstarNode second)
        {
            FurniturePartView furuniture = null;
            var firstWall = Wall.FREE_WALL;
            var secondWall = Wall.FREE_WALL;
            if (first.under != null)
            {
                furuniture = first.under;
                if (furuniture != null)
                {
                    firstWall = Wall.rotateWall(furuniture.data.wall, furuniture.place.direction);
                }
            }
            if (second.under != null)
            {
                furuniture = second.under;
                if (furuniture != null)
                {
                    secondWall = Wall.rotateWall(furuniture.data.wall, furuniture.place.direction);
                }
            }
            var saX = first.x - second.x;
            var saY = first.y - second.y;
            if (saX < 0 && saY < 0)
            {
                if (firstWall.east || firstWall.south || secondWall.north || secondWall.west)
                {
                    return false;
                }
            }
            else if (saX < 0 && saY == 0)
            {
                if (firstWall.east || secondWall.west)
                {
                    return false;
                }
            }
            else if (saX < 0 && saY > 0)
            {
                if (firstWall.north || firstWall.east || secondWall.west || secondWall.south)
                {
                    return false;
                }
            }
            else if (saX == 0 && saY < 0)
            {
                if (firstWall.south || secondWall.north)
                {
                    return false;
                }
            }
            else if (saX == 0 && saY > 0)
            {
                if (firstWall.north || secondWall.south)
                {
                    return false;
                }
            }
            else if (saX > 0 && saY < 0)
            {
                if (firstWall.west || firstWall.south || secondWall.east || secondWall.north)
                {
                    return false;
                }
            }
            else if (saX > 0 && saY == 0)
            {
                if (firstWall.west || secondWall.east)
                {
                    return false;
                }
            }
            else if (saX > 0 && saY > 0)
            {
                if (firstWall.west || firstWall.north || secondWall.east || secondWall.south)
                {
                    return false;
                }
            }
            return true;
        }



    }
    public class compareNode : IComparer<AstarNode>
    {

        public int Compare(AstarNode x, AstarNode y)
        {
            var _loc_3 = x.z;
            var _loc_4 = y.z;
            if (_loc_3 < _loc_4)
            {
                return -1;
            }
            if (_loc_3 == _loc_4)
            {
                return 0;
            }
            return 1;
        }
    }
}
