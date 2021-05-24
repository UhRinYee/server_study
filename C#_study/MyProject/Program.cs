using System;
//using MyProject.Util;                           // 이렇게 using 하면 Enc사용 가능

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            my_class a = new my_class();
            MyProject.Util.Encryptor enc = new MyProject.Util.Encryptor();
        }
    }
}
