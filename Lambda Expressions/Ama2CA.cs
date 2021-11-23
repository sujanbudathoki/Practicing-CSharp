using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
   public class Ama2CA
    {
        public void WriteThis(string firstName,string lastName,string job)
        {
            Console.WriteLine($"{firstName} {lastName} do this {job}.");
            
        }

        public static void NewMain()
        {
            Ama2CA obj = new Ama2CA();
            Func<void, string, string, string> myDel = obj.WriteThis;
            myDel.Invoke("Hari", "Chauhan", "Carpenter");
            myDel.Invoke("Karim", "Amad", "Safiq");


        }
    }
}
