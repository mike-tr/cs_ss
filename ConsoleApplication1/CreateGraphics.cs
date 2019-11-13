using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CreateGraphics
    {
        public static StartProgram instance; 
        public static void Main()
        {
            Console.WriteLine("??2");
            instance = new StartProgram();
            var game = new Game();
            instance.Start(game, true);

            instance.Refresh();
            instance.Refresh();
            
            instance.Refresh();
            instance.Refresh();
            //program.ReDraw();
            //program.ShowConsole(true);
        }
    }
}
