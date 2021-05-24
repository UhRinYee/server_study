using System;

namespace ConsoleApp1
{
    class struct_ex
    {
        struct Rect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
            public Rect(int left, int top, int width, int height)       // 구조체에 생성자가 선언이 된다... 개 혁명;
            {
                Left = left;
                Top = top;
                Width = width;
                Height = height;
            }
        }

        static void Main(String[] args)
        {
            Rect r = new Rect();
            r.Left = 10;
            r.Top = 10;
            r.Width = 10;
            r.Height = 10;

            Draw(r);
        }

        static void Draw(Rect r)
        {
            DrawRectangle(r);
            PrintData(r);
        }

        static void DrawRectangle(Rect r)
        {
            //.... 생략 ....
        }
        static void PrintData(Rect r)
        {
            int right = r.Left + r.Width;
            int bottom = r.Top + r.Height;
            Console.WriteLine($"{r.Left},{r.Top} ~ {right},{bottom}");
        }
    }
}