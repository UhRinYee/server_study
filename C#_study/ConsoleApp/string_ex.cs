using System;

namespace ConsoleApp2
{
    class string_ex
    {
        static void Main(string[] args)
        {
            //string s1 = "C#";
            string s2 = "Programming";

            //char c1 = 'A';
            //char c2 = 'B';

            //// 문자열 결합
            //string s3 = s1 + " " + s2;
            //Console.WriteLine("String : {0}",s3);

            //// 문자열 부분 발췌
            //string s3substring = s3.Substring(1, 5);    // 1 ~ 5번 인덱스까지 복사
            //Console.WriteLine("Substring : {0}", s3substring);

            // 문자열 치환
            string s5 = s2.Replace("Pro", "PRO");
            Console.WriteLine(s5);

            // 문자열 삭제
            s2.Remove(3);       // Pro

            // 문자열, 문자, 문자배열
            string s = "C# studies";
            
            // 문자열을 배열인덱스로 한문자 엑세스
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, s[i]);
            }

            // 문자열을 문자배열로 변환
            string str = "Hello";
            char[] CharArray = str.ToCharArray();

            for(int i = 0; i < CharArray.Length; i++)
            {
                Console.WriteLine(CharArray[i]);
            }

            // 문자배열을 문자열로 변환
            char[] CharArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(CharArray2);

            Console.WriteLine(s);

            // 문자연산
            char c1 = 'A';
            char c2 = (char)(c1 + 3);
            Console.WriteLine(c2);
        }
    }
}