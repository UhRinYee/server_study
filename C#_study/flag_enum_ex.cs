using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class flag_enum_ex
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,        // 0000 0001
            Right = 2,
            Bottom = 4,     // 0000 0011
            Left = 8
        }
        static void Main(String[] args)
        {
            // OR 연산자로 다중 플래그 할당
            Border b = Border.Top | Border.Bottom;

            // & 연산자로 플래그 체크
            if((b & Border.Top) != 0)                   // b에 Border.Top이 없음
            {
                // HasFlag()이용 플래그 체크
                if (b.HasFlag(Border.Bottom))           // 
                {
                    // "Top, Bottom"출력
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}