using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace not_usb
{
    class try_catch_ex
    {
        static void Main(String[] args)
        {
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Run()
        {
            try
            {
                int[] a = new int[10];
                for (int i = 0; i <= 10; i++)
                {
                    a[i] = i;
                    Console.WriteLine(a[i]);
                }
                var fs = File.Open("My.config", FileMode.Open);
            }

            catch (IndexOutOfRangeException ex)
            {
                //..
            }
            catch(FileNotFoundException ex)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
