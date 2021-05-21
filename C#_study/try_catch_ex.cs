using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_usb
{
    class try_catch_ex
    {
        static void Main(String[] args)
        {
            Run();
        }

        static void Run()
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
        }
    }
}
