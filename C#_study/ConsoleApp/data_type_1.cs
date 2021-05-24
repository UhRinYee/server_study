using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class data_type_1
    {
        static void Main(string[] args)
        {
            // var : 대입되는 데이터에 따라 데이터형 결정
            // null값 초기화, 매개변수로 사용 불가
            // 지역변수로만 사용이 가능
            // 연속적으로 초기화가 불가능.

            // var 예제
            //var value1 = 3.14f;
            //float value2 = 10.12f;
            //float sum = value1 + value2;
            //Console.WriteLine("{0} + {1:f2} = {2}", value1, value2, sum);

            // nullable : null을 허용하지않는 데이터형이 null값을 허용

            // nullable 예제
            //int? Num1 = null;
            //if (Num1.HasValue)
            //    Console.WriteLine("올바른 값");
            //else
            //    Console.WriteLine("null 값");

            //Console.WriteLine("null : {0}", Num1);

            //데이터 변환
            //데이터 변환 예제
            //int value1 = 127;
            //string str1 = value1.ToString();
            //Console.WriteLine(str1);

            //int value2 = Convert.ToInt32(str1);     // int.Parse()
            //Console.WriteLine(value2);

            //string str2 = "3.14";
            //float value3 = float.Parse(str2);       // Convert.ToSingle()
            //Console.WriteLine(value3);

            // 박싱(boxing)
            // int boxing , unboxing 예제
            //int i = 123;
            //object obj = i;
            //Console.WriteLine("{0}", (int)obj);

            // boxing은 값을 복사하는 용도이다. pointer같은게 아님.
            //int i = 123;
            //object o = i;
            //i = 456;
            //Console.WriteLine("{0} {1}", i, (int)o);

        }
    }
}
