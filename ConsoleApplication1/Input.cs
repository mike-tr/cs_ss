using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    static class Input
    {
        private static int TICKS = 0;
        static public void AddKey(Keys key)
        {
            GInput<Keys>.Add(key);
        }

        static public void RemoveKey(Keys key)
        {
            GInput<Keys>.Remove(key);
        }

        static public bool GetKeyDown(Keys key)
        {
            return GInput<Keys>.GetDown(key);
        }

        static public bool GeyKeyUp(Keys key)
        {
            return GInput<Keys>.GetUp(key);
        }

        static public bool GetKey(Keys key)
        {
            return GInput<Keys>.GetPressed(key);
        }

        static public void AddButton(MouseButtons button)
        {
            GInput<MouseButtons>.Add(button);
        }

        static public void RemoveButton(MouseButtons button)
        {
            GInput<MouseButtons>.Remove(button);
        }

        static public bool GetButtonDown(MouseButtons button)
        {
            return GInput<MouseButtons>.GetDown(button);
        }

        static public bool GetButtonUp(MouseButtons button)
        {
            return GInput<MouseButtons>.GetUp(button);
        }

        static public bool GetButton(MouseButtons button)
        {
            return GInput<MouseButtons>.GetPressed(button);
        }

        static public void Update()
        {
            GInput<Keys>.Update();
            GInput<MouseButtons>.Update();
            TICKS++;
        }
    }
}
