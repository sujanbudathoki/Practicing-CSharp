using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
    public  class TupleLambada
    {
        public TupleLambada()
        {
            Console.WriteLine("Tuple Lambada class loaded");
        }
        public delegate Tuple<int, double> myDelegate(Tuple<int,double> myTuple);
        public void staticRun(Tuple<int,double> myTuple)
        {
            var tuple = Tuple.Create<int, double>(1, 2.5);
            myDelegate delObj = (Tuple<int, double> item) => Tuple.Create(item.Item1 * 2, item.Item2 * 2);
        }
    }
}
