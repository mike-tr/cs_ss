using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MainLoop
    {
        public static StartProgram instance;
        public static int SleepTime = 50;

        public static void Main()
        {
            Console.WriteLine("??2");
            instance = new StartProgram();
            var game = new Game();
            instance.Start(game);

            //instance.Refresh();
            //program.ReDraw();
            //program.ShowConsole(true);
        }
    }
}
