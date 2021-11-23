using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
    public class SumProblem
    {
        public delegate void myDel(int x, int y);

        public static void Executor()
        {
            //using anonymus method
            myDel delInstance1 = delegate (int x, int y)
            {
                int sum = x + y;
                Console.WriteLine($"Sum of number 4 and 5 using anonymus method is {sum}");

            };
          

            //using lambda expressions
            myDel delInstance2 = (x, y) =>
            {
                int sum = x + y;
                Console.WriteLine($"Sum of number 4 and 5 using lambda expression is{sum}");

            };

        }

        public int sum(int x, int y) => x + y;
    }
}