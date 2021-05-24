using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class data_type
    {
        static void Main(string[] args)
        {
            bool b = true;

            short sh = 100;
            int i = 100;
            long l = 10000;

            float f = 3.14f;              // 32bit, float는 뒤에 f를 붙여야함
            double d = 3.141592;         // 64bit
            decimal dd = 3.14M;          // 128bit decimal은 뒤에 m을 붙여야함

            string s = "Hello";

            char ch = '한';              // 16bit Unicode

            byte by = 0x46;              // 8bit

            // byte : 1바이트 "숫자" 자료형
            // char : 1바이트 "문자" 자료형
            // char에 C언어처럼 숫자를 넣어 아스키코드로 치환할 수 없음

            int? ix = null;             // 타입 뒤에 ?를 붙이면 null로 선언이 가능 
            if(ix == null)
            {
                Console.WriteLine("ix is null");
            }
            else
            {
                Console.WriteLine(ix.Value);
            }

            object o = 123;              // 뭐든 다 받음

            // 레퍼런스 타입
            // string, object는 null을 지정할 수 있다.

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            //int?를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;

        }
    }
}

// value type 데이터에 null형으로 만들어주는 이유가 있나?
// 데이타베이스에 NULL이 허용된 INT 컬럼이 있을 때 C#에서 int? 로 매핑할 수 있다.