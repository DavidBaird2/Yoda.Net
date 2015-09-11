using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Room
{
    public class Wall
    {
        //trueだと壁がある（通り抜けられない）;
        public bool north;
        public bool south;
        public bool east;
        public bool west;
        public static Wall[] WALLS = new Wall[16] { new Wall(false, false, false, false), new Wall(false, false, false, true), new Wall(false, false, true, false), new Wall(false, false, true, true), new Wall(false, true, false, false), new Wall(false, true, false, true), new Wall(false, true, true, false), new Wall(false, true, true, true), new Wall(true, false, false, false), new Wall(true, false, false, true), new Wall(true, false, true, false), new Wall(true, false, true, true), new Wall(true, true, false, false), new Wall(true, true, false, true), new Wall(true, true, true, false), new Wall(true, true, true, true) };
        public static Wall FREE_WALL = WALLS[0];

        public Wall(bool south, bool east, bool north, bool west)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
            return;
        }

        
        public byte GetWallCode()
        {
            byte count = 0;
            foreach (Wall wall in WALLS)
            {
                if (wall == this)
                    break;
                count++;
            }
            return count;
        }

        public string toString()
        {
            return "";
        }

        public static Wall rotateWall(Wall from, int dir)
        {
            if (dir == 0)
            {
                return from;
            }
            if (dir == 1)
            {
                return getWall(from.west, from.south, from.east, from.north);
            }
            if (dir == 2)
            {
                return getWall(from.north, from.west, from.south, from.east);
            }
            if (dir == 3)
            {
                return getWall(from.east, from.north, from.west, from.south);
            }
            return from;
        }

        public static Wall getWall(bool north, bool east, bool south, bool west)
        {
            foreach (Wall wall in WALLS)
            {
                if (wall.north == north && wall.east == east && wall.south == south && wall.west == west)
                    return wall;
            }
            return null;
        }
    }
}
