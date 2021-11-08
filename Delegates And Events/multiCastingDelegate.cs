using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.SharpC
{
    public class multiCasting
    {
        public delegate void myDelegate();

        public delegate int returnintTaketwoInt(int x, int y);
        public void Mymethod() => Console.WriteLine("Hello");
        public void Mymethod2() => Console.WriteLine("Jello");
        public void multiMain()
        {
            var func = new returnintTaketwoInt();
            var func2 = new myDelegate(Mymethod());
            func.Invoke(Sum());
            var sum = func(3, 4);
            Console.WriteLine($"Sum- {sum}");



        }
        private int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
