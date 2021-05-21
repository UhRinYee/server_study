using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_usb
{
    class Program
    {
        static Class1 c;
        static void Main(string[] args)
        {
         
            // ??연산자
            // ??왼쪽의 값이 null인경우 ??뒤의 값을리턴
            // 아니라면, 왼쪽값을 리턴한다.
            int? i = null;
            i = i ?? 0;

            string s = null;
            s = s ?? string.Empty;
        }
    }
}
