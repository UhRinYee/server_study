using System;
using System.Drawing;

namespace ConsoleApp1
{
    class class_ex
    {
        // 필드
        private int width;
        private int height;
        private int depth;
        private Color color;        // System.Drawing

        // 생성자 (Constructor)
        // private : class 내에서만 사용 가능
        // public : 접근제한자 외부에서 member 엑세스 가능
        public class_ex()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }

        public class_ex(int width, int height, int depth, Color color)
        {
            this.width = width;                     //this : class의 member 참조
            this.height = height;
            this.depth = depth;
            this.color = color;
        }

        // 속성 (property)
        public int Width
        {
            get { return this.width; }      // 읽기 전용
            set {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }
        public Color Color
        {
            get { return this.color; }
        }

        public int Volume
        {
            get { return width * height * depth; }
        }

        // 메서드 (Method)
        public void MakeBrick()
        {
            //Event Fire
            if (ProcessStarted != null)
            {
                ProcessStarted(this, EventArgs.Empty);
            }
            Step1();
            Step2();
            Step3();

            if (ProcessCompleted != null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }

        private void Step1()
        {
            Console.WriteLine("# Step1 #");
        }
        private void Step2()
        {
            Console.WriteLine("# Step2 #");
        }
        private void Step3()
        {
            Console.WriteLine("# Step3 #");
        }

        // 이벤트
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessCompleted;
    }
}