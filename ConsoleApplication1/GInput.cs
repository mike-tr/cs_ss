using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class GInput<T>
    {
        private static HashSet<T> addList = new HashSet<T>();
        private static HashSet<T> pressed = new HashSet<T>();
        private static HashSet<T> removeList = new HashSet<T>();
        static public void Add(T key)
        {
            addList.Add(key);
        }

        static public void Remove(T key)
        {
            removeList.Add(key);
        }

        static public bool GetDown(T key)
        {
            return addList.Contains(key);
        }

        static public bool GetUp(T key)
        {
            return removeList.Contains(key);
        }

        static public bool GetPressed(T key)
        {
            return pressed.Contains(key);
        }

        static public void Update()
        {
            foreach (var key in addList)
            {
                pressed.Add(key);
            }
            foreach (var key in removeList)
            {
                pressed.Remove(key);
            }
            addList = new HashSet<T>();
            removeList = new HashSet<T>();
        }
    }
}
