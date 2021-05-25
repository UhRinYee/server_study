using System;
using System.Drawing;

namespace ConsoleApp1
{
    class class_ex_main_program
    {
        static void Main(String[] args)
        {
            class_ex brick1 = new class_ex();            // class_ex 객체를 brick에 할당
            class_ex brick2 = new class_ex(50, 100, 20, Color.Gray);

            int w = brick2.Width;
            brick2.Width = 100;                 // get을 사용하면 읽기전용이므로 실행 불가.
                                                // set도 사용
            int w2 = brick2.Width;
            Color c = brick2.Color;             

            Console.WriteLine(w);
            Console.WriteLine(w2);
            Console.WriteLine(c);

            int v = brick2.Volume;

            Console.WriteLine(v);

            brick2.ProcessStarted += Brick2_ProcessStarted;
            brick2.ProcessCompleted += Brick2_ProcessCompleted;
            brick2.MakeBrick();

        }

        private static void Brick2_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Started");
        }

        private static void Brick2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed");
        }
    }
}