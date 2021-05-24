using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_usb
{
    class yield_ex
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;        // 첫번째 루프에서 리턴되는 값
            yield return 20;
            yield return 30;
        }
        static void Main(String[] args)
        {
            foreach(int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
