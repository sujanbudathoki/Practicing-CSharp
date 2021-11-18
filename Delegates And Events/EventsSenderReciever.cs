using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.Delegates_And_Events
{
    public class JobEvent : EventArgs
    {
        int jobNo = 0;
        public int JobNo
        {
            get { return JobNo; }
            set { jobNo = value; }
        }
    }

    public delegate void MyEventHandler(object sender, JobEvent e);

    interface IMyEvent
    {
      event MyEventHandler myEvent;
    }

    public class Sender : IMyEvent
    {
        public event MyEventHandler myEvent;
        private int myInt;
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
                OnMyIntChanged();

            }
        }
        protected virtual void OnMyIntChanged()
        {
            if (myEvent != null) //checking if an event is subscribed to function.
            {
                JobEvent eventObj = new JobEvent();
                eventObj.JobNo = myInt;
                myEvent(this, eventObj);
            }
        }
    }

  
    public class Reciever
    {
        public void getNotification(object sender, JobEvent e)
        {
            Console.WriteLine("Integer Value Has Been Changed to {0}",e.JobNo);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}
