using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
   public class Employee
    {
        public int empId;
        public string company;
        public string name;
        public Employee(int Id)
        {
            this.empId = Id;
        }

        public string Company => company; // readonly property which returns company.

        public string Name
        {
            get => name;
            set => name = value;//returns void.
        }

    }
}
