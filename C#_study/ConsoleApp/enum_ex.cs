using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class enum_ex
    {
        enum City
        {
            Seoul,          // 0
            Daejun,         // 1
            Busan = 5 ,     // 5
            Jeju = 10       // 10
        }

        static void Main(String[] args)
        {
            City MyCity;

            // enum 타입에 값을 대입하는 방법
            MyCity = City.Seoul;

            // enum을 int로 치환(casting) 하는 방법
            // (int)를 앞에 지정.
            int CityValue = (int)MyCity;

            if(MyCity == City.Seoul)
            {
                Console.WriteLine("Welcome to Seoul");
            }
        }
    }
}
