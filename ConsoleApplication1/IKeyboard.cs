using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    interface IKeyboard
    {
        void OnKeyDown(Keys key);

        void OnKeyUp(Keys key);

        void OnKey(Keys key);
    }
}
