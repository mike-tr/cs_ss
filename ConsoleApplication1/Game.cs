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

        int x = 0;
        int y = 0;

        public void Draw(Graphics graphics)
        {
            this.graphics = graphics;
            graphics.Clear(Color.Black);
            //graphics.DrawRectangle(new Pen(Color.Red, 50), 26, 26, 50, 50);
            CreateFilledRect(Color.White, x, y, 10, 10);

            x += 1;
            y += 1;
        }

        private void CreateFilledRect(Color color, int x, int y, int width, int height)
        {
            x = width / 2 + x;
            y = width / 2 + y;
            graphics.DrawRectangle(new Pen(color, width), x, y, width, height);
        }
    }
}
