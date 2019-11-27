using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Game : IDrawable
    {
        private Graphics graphics;

        const int tileSize = 20;

        int sizex = 20;
        int sizey = 20;

        Grid grid;

        const int dtile = -1;

        public static int dir = 1;

        Tile head;

        public Game()
        {
            grid = new Grid(tileSize, tileSize, sizex, sizey);
            grid.ForeachTileDo(CreateBorders);
            //grid.Get(10, 10).value = dtile;

            head = new Tile(10, 10, 1);
            

            MainLoop.instance.Size = new Size((sizex + 1) * tileSize - 4, (sizey + 1) * tileSize + 19);
        }

        public void Draw(Graphics graphics)
        {
            if (Input.GetKeyDown(Keys.Space))
            {
                dir *= -1;
            }
            if (Input.GetButtonDown(MouseButtons.Left))
            {
                dir = 0;
            }
            if (Input.GetButtonUp(MouseButtons.Left))
            {
                dir = 1;
            }

            this.graphics = graphics;
            graphics.Clear(Color.Black);
            DrawTile(head);
            grid.ForeachTileDo(DrawTile);

            head.pos.x += dir;
        }

        int DrawTile(Tile tile)
        {
            if(tile.value == dtile)
            {
                CreateFilledRect(Color.Red, tile.pos.x * tileSize, tile.pos.y * tileSize, 9, 9);
            }else if(tile.value > 0)
            {
                CreateFilledRect(Color.White, tile.pos.x * tileSize, tile.pos.y * tileSize, 9, 9);
            }
            return 0;
        }

        int CreateBorders(Tile tile)
        {
            if(tile.pos.x == 0 || tile.pos.y == 0 || tile.pos.x == grid.size.x - 1 || tile.pos.y == grid.size.y - 1)
            {
                tile.value = dtile;
            }
            return 0;
        }

        private void CreateFilledRect(Color color, int x, int y, int width, int height)
        {
            x = (width + 1) / 2 + x;
            y = (width + 1) / 2 + y;
            graphics.DrawRectangle(new Pen(color, width), x, y, width, height);
        }
    }
}
