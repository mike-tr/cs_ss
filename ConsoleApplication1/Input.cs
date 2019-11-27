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

        private static HashSet<Keys> toAdd = new HashSet<Keys>();
        private static HashSet<Keys> keys = new HashSet<Keys>();
        private static HashSet<Keys> toRemove = new HashSet<Keys>();
        static public void AddKey(Keys key)
        {
            toAdd.Add(key);
        }

        static public void RemoveKey(Keys key)
        {
            toRemove.Add(key);
        }

        static public bool GetKeyDown(Keys key)
        {
            return toAdd.Contains(key);
        }

        static public bool GeyKeyUp(Keys key)
        {
            return toRemove.Contains(key);
        }

        static public bool GetKey(Keys key)
        {
            return keys.Contains(key);
        }

        static public void Update()
        {
            foreach(var key in toAdd)
            {
                keys.Add(key);       
            }
            foreach(var key in toRemove)
            {
                keys.Remove(key);
            }
            toAdd = new HashSet<Keys>();
            toRemove = new HashSet<Keys>();
            TICKS++;
        }
    }
}
