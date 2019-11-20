using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    struct Vector2Int
    {
        public Vector2Int(int x,int y) { this.x = x; this.y = y; }
        public int x;
        public int y;

        public static Vector2Int Zero()
        {
            return new Vector2Int(0, 0);
        }
    }

    class Tile
    {
        public Tile(int x,int y,float v)
        {
            pos = new Vector2Int(x, y);
            value = v;
        }
        public Vector2Int pos;
        public float value;
    }
    class Grid
    {
        const int xoffset = -4;
        const int yoffset = 19;

        public Vector2Int tileSize;
        public Vector2Int size;

        Tile[,] map;
        public Grid(int tileSizeX, int tileSizeY,int sizeX,int sizeY)
        {
            tileSize = new Vector2Int(tileSizeX, tileSizeY);
            size = new Vector2Int(sizeX, sizeY);
            map = new Tile[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    map[x, y] = new Tile(x, y, 0);
                }
            }
        }

        public void ForeachTileDo(Func<Tile, int> DoStuff)
        {
            foreach(Tile tile in map)
            {
                DoStuff(tile);
            }
        }

        public Tile Get(int x, int y)
        {
            if(x < 0 || x > size.x - 1 || y < 0 || y > size.y - 1)
            {
                return null;
            }
            return map[x, y];
        }
    }
}
