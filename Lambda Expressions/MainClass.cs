using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
    public class MainProgram
    {
        public static void ThisMain()
        {
            Console.WriteLine("This is my Lambda Expression Program");
            Eventual obj = new Eventual();
            EventHandler thisEvent = (object sender, EventArgs e) => Console.WriteLine("The Value is changed.");
            obj.myEvent += thisEvent;
            obj.MyNum = 2;

        }
    }
}
