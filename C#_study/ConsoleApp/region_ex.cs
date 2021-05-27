//#define EX_1

//#if(!EX1)
//#warning This class should be used in EX1
//#error This class should be used in EX1
//#endif

using System;

//#pragma warning disable 169

namespace ConsoleApp1
{
    class region_ex
    {
        #region Fields
        private bool debug;
        private string key;
        #endregion

        #region Properties
        public int Id { get; set; }
        #endregion

        #region Methods
        public void Encrypt() { }
        public void Decrypt() { }
        #endregion

        public void Run()
        {
#pragma warning disable
            if (false)
            {
                var b = Step1();
                if (b)
                {
                    Step2();
                }
                else
                {
                    Step3();
                }
            }
#pragma warning restore
        }

        private bool Step1() { return true; }
        private bool Step2() { return true; }
        private bool Step3() { return true; }


    }
}