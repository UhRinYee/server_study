#define TEST_ENV
using System;

namespace ConsoleApp1
{
    class def_ex
    {
        static void Main(string[] args)
        {
            bool verbose = false;

#if (TEST_ENV)
            Console.WriteLine("Test Environment : Verbose option i set.");
            verbose = true;

#else
            Console.WriteLine("Production");
#endif

            if (verbose)
                Console.WriteLine("Verbose mode");
        }
    }
}