using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class public_input
    {
        static void Main(string[] args)
        {
            // 표준입력 예제
            //ConsoleKeyInfo KeyInfo;
            //do
            //{
            //    KeyInfo = Console.ReadKey();
            //    if (KeyInfo.Key == ConsoleKey.A)
            //        Console.WriteLine("a가 눌렸다!");
            //} while (KeyInfo.Key != ConsoleKey.Escape);

            //ConsoleKeyInfo KeyInfo;
            //do
            //{
            //    KeyInfo = Console.ReadKey(true);
            //    if(KeyInfo.KeyChar == 'a')
            //        Console.WriteLine("a가 눌렸어!");
            //} while (KeyInfo.Key != ConsoleKey.Escape);

            // Console.ReadKey() : Key "한 개"만 받는것
            // 위 예제에서 여러개를 받는 이유는 while문을 썻기때문이다.
            //Console.ReadKey()의 인자는 true라면 화면에 보여주지않고
            //Console.ReadKey()의 인자가 false라면 화면에 보여준다.(기본값)

            // .KeyChar는 대소문자를 구분해준다 당연히 .Key는 대소문자 구분x

            int kor, Eng, Math, Total;
            float Average;

            Console.Write("국어 점수를 입력해 주세요 : ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력해 주세요 : ");
            Eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력해 주세요 : ");
            Math = int.Parse(Console.ReadLine());

            Total = kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4}", kor, Eng, Math, Total, Average);
            
            // Console.ReadLine() : 다른 언어의 scanf 혹은 input과 같은 코드이다.
        }
    }
}

// https://www.youtube.com/watch?v=LYafPZiUmW0&list=PLOKPEzlY4JKQNiHEQ4SDBxAFo9RDod8Tm&index=10&ab_channel=%EB%82%98%EC%9A%B0%EC%BA%A0%ED%8D%BC%EC%8A%A4X%EC%95%84%EC%9B%8C%EC%A6%88%ED%8C%9C
// 위 링크 데이터형(3/5)까지 봄.