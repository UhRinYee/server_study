#define PROD_ENV

using System;

namespace ConsoleApp1
{
    class def_ex2
    {
        public string GetServer()
        {
            string server;
#if (TEST_ENV)
            server = "TESTSERVER";
#else
            server = "PRODSERVER";
#endif
            return server;
        }
    }
}