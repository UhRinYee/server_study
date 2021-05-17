using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class array
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] scores = { 80, 78, 60, 90, 100 };
            for (int i = 0; i < scores.Length; i++)
                sum += scores[i];
            Console.WriteLine(sum);

        }
    }
}