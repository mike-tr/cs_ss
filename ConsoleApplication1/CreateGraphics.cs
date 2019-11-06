using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CreateGraphics
    {
        public static void Main()
        {
            Console.WriteLine("??2");
            var program = new StartProgram();
            var game = new Game();
            program.Start(game, true);
            //program.ShowConsole(true);
        }
    }
}
