using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class StartProgram : Form
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        Graphics graphics;
        IDrawable drawable;
        

        public void Start(IDrawable draw ,bool hideConsole = false)
        {
            drawable = draw;
            ShowConsole(!hideConsole);
            Application.Run(this);
        }

        public void ShowConsole(bool show)
        {
            var console = GetConsoleWindow();
            int v = show ? 5 : 0;
            ShowWindow(console, v);
        }

        public StartProgram()
        {
            this.Paint += new PaintEventHandler(draw);
            this.Paint += new PaintEventHandler(draw);
        }

        int x = 0;
        private void draw(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawable.Draw(graphics);
            //graphics.Clear(Color.Black);
            //graphics.DrawString("Hello C#", new Font("Verdana", 20), new SolidBrush(Color.Tomato), x, 40);
            //graphics.DrawRectangle(new Pen(Color.Pink, 3), x, 20, 150, 100);
            //graphics.DrawRectangle(new Pen(Color.Red, 50), 26, 26, 50, 50);

            //CreateFilledRect(Color.White, 0, 30, 30, 30);
            //x += 20;
        }

        private void CreateFilledRect(Color color, int x, int y, int width, int height)
        {
            x = width / 2 + x;
            y = width / 2 + y;
            graphics.DrawRectangle(new Pen(color, width), x, y, width, height);
        }
    }
}
