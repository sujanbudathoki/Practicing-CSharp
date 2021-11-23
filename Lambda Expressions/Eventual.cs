using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Lambda_Expressions
{
   public class Eventual
    {
        private int myNum;
        public int MyNum
        {
            get=>myNum;
            set 
            { 
                myNum = value;
                onMyIntChanged();
            }
        }
        public event EventHandler myEvent;
        public void onMyIntChanged()
        {
            if (myEvent != null)
            {
                myEvent(this, EventArgs.Empty);
            }
        }

    }

}
