using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
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

        Bitmap bm = new Bitmap(1000, 1000);
        Graphics bmg;


        public void Start(IDrawable draw ,bool hideConsole = false)
        {
            drawable = draw;
            ShowConsole(!hideConsole);
            DoubleBuffered = true;
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
            this.Paint += new PaintEventHandler(Draw);
            //this.Paint += new PaintEventHandler(Draw);
            this.Invalidate();
            
        }

        int x = 0;
        private void Draw(object sender, PaintEventArgs e)
        {
            this.Invalidate();
            graphics = e.Graphics;
            drawable.Draw(graphics);
            Thread.Sleep(10);
            
        }

        private void CreateFilledRect(Color color, int x, int y, int width, int height)
        {
            x = width / 2 + x;
            y = width / 2 + y;
            graphics.DrawRectangle(new Pen(color, width), x, y, width, height);
        }
    }
}
