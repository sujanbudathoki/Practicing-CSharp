using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
   public class SumProblem
    {
        public delegate int myDel(int x, int y);

        public static void Executor()
        {
            //using anonymus method
            myDel delInstance1 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine($"Sum of number 4 and 5 using anonymus method is {delInstance1(4,5)}");

            //using lambda expressions
            myDel delInstance2 = (x, y) => 
            {
                return x + y; 
            };
            Console.WriteLine($"Sum of number 4 and 5 using lambda expression is {delInstance2(4, 5)}");
        }

    }
}
