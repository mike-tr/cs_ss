using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    class Game : IDrawable
    {
        private Graphics graphics;

        const int tileSize = 20;

        int sizex = 20;
        int sizey = 20;

        int[,] map;

        public Game()
        {
            map = new int[sizex, sizey];
            for (int y = 0; y < sizey; y++)
            {
                for (int x = 0; x < sizex; x++)
                {
                    if(x == 0 || y == 0 || y == sizey - 1 || x == sizex - 1)
                    {
                        map[x, y] = 1;
                    }
                }
            }
            map[10, 10] = 1;
            map[9, 9] = 1;
            map[18, 18] = 1;
            map[17, 17] = 1;
            map[1, 1] = 1;
            map[2, 2] = 1;
            CreateGraphics.instance.Size = new Size((sizex + 1) * tileSize - 4, (sizey + 1) * tileSize + 19);
        }

        public void Draw(Graphics graphics)
        {
            this.graphics = graphics;
            graphics.Clear(Color.Black);
            //graphics.DrawRectangle(new Pen(Color.Red, 50), 26, 26, 50, 50);
            CreateFilledRect(Color.Red, (sizex - 2) * tileSize, 1, tileSize, tileSize);
            for (int y = 0; y < sizey; y++)
            {
                for (int x = 0; x < sizex; x++)
                {
                    if(map[x,y] == 1)
                    {
                        CreateFilledRect(Color.White, x * tileSize, y * tileSize, 9, 9);
                    }
                }
            }
        }

        private void CreateFilledRect(Color color, int x, int y, int width, int height)
        {
            x = (width + 1) / 2 + x;
            y = (width + 1) / 2 + y;
            graphics.DrawRectangle(new Pen(color, width), x, y, width, height);
        }
    }
}
