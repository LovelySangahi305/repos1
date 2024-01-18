using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class Obsoleteattr
    {
        [Obsolete]
        public void Function1()
        {
            Console.WriteLine("Function1");
        }

        public void Function2()
        {
            Console.WriteLine("Function2");
        }
    }
    internal class Kernel
    { 
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);
    }
}
