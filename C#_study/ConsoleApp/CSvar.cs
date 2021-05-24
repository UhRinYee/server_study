using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSvar
    {
        // 필드 (클래스 내에서 공통적으로 사용되는 전역변수)
        int globalVar;                  // field는 초기화하지않으면 자동으로 0으로 초기화된다.
        
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드
        readonly int Max;

        public CSvar()
        {
            Max = 1;
        }

        public void Method1()
        {

            // 로컬변수
            int localVar;

            // 아래 할당이 없으면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        // 모든 프로그램에는 Main()이 있어야함
        static void Main(string[] args)
        {
            // 테스트
            CSvar obj = new CSvar();
            obj.Method1();
        }
    }
}
