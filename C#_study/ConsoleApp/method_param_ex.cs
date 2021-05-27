using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class method_param_ex
    {
        static void Main(String[] args)
        {
            var calc = new Calculator();

            int a = 5;
            int b = 10;
            
            // C# ref
            calc.Double(a, ref b);                  // b = pass by refence : ref
                                                    // a = pass by value 

            Console.WriteLine("a = {0}, b = {1}", a, b);

            // C# out  but, 변수안에 값이 있으면 실행이 안됨 그럴때엔 out이 아닌 ref
            //int sum;
            //double avg;
            //calc.GetSumAndAvg(5, 15, out sum, out avg);

            //Console.WriteLine("sum = {0}, avg = {1}",sum,avg);

            // C# 7.0
            //calc.GetSumAndAvg(5, 15, out int sum, out double avg);      // 여기서 선언가능
            //calc.GetSumAndAvg(5, 15, out var sum, out var avg);         // 프로토타입으로 파라미터를 보고 자료형 결정
            //calc.GetSumAndAvg(5, 15, out var sum, out _);

            // C# params : 가변 파라미터
            //int s = calc.Sum(1);
            //s = calc.Sum(1, 2);
            //s = calc.Sum(1, 2, 3, 4, 5);
            //s = calc.Sum();

            // Named Parameter, optional Parameter
            var st = new StudentList();
            st.AddStudent("Tim", "111-2222", 10);
            st.AddStudent("Tim", "111-2222");                           // optional parameter
            st.AddStudent(name: "Tim", age: 10, phone: "111-2222");     // named parameter
        }
    }

    class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }

    class StudentList
    {
        private List<student> students = new List<student>();

        public void AddStudent (string name, string phone, int age = 0)     // 디폴트값 선언 가능
        {
            var s = new student();
            s.Name = name;
            s.Age = age;
            s.Phone = phone;
            students.Add(s);
        }
    }

    class Calculator
    {
        public void Double(int a, ref int b)
        {
            a *= 2;
            b *= 2;
        }

        public bool GetSumAndAvg(int a, int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = sum / 2;
            return true;
        }
        public int Sum(params int[] values)
        {
            int sum = 0;
            foreach(var v in values)
            {
                sum += v;
            }
            return sum;
        }
    }
}