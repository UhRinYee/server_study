using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_usb
{
    class yield_ex2
    {
        static void Main(String[] args)
        {
            foreach(var score in GetScores())
            {
                Console.WriteLine(score);
            }
        }

        static IEnumerable<int> GetScores()
        {
            int[] scores = new int[] { 10, 20, 30, 40, 50 };
            foreach(int i in scores)
            {
                if (i == 30)
                    yield break;            // yield break는 이렇게 사용이 가능

                yield return i;
            }
        }
    }
}
