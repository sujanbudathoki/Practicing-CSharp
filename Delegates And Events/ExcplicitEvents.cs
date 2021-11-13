using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Delegates_And_Events
{
    interface IBeforeEvents
    {
        public event EventHandler OnMyIntChanged;
    }

    interface IAfterEvents
    {
        public event EventHandler OnMyIntChanged;
    }

    public class SenderExcClass : IBeforeEvents, IAfterEvents
    {
        //creating 2 events
        public event EventHandler BeforeIntChanged;
        public event EventHandler AfterIntChanged;
        //creating object for lock
        object objecLock = new object();
        private int myInt;
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                BeforeIntChangedFunc();
                myInt = value;
                AfterIntChangedFunc();
            }
        }
        event EventHandler IBeforeEvents.OnMyIntChanged
        {
            add
            {
                lock (objecLock)
                {
                    BeforeIntChanged += value;
                }
            }

            remove
            {
                lock (objecLock)
                {
                    BeforeIntChanged -= value;
                }
            }
        }

        event EventHandler IAfterEvents.OnMyIntChanged
        {
            add
            {
                lock (objecLock)
                {
                    AfterIntChanged += value;
                }
            }

            remove
            {
                lock (objecLock)
                {
                    AfterIntChanged += value;
                }
            }
        }
        public void BeforeIntChangedFunc()
        {
            if (BeforeIntChanged != null)
            {
                BeforeIntChanged(this, EventArgs.Empty);
            }
        }
        public void AfterIntChangedFunc()
        {
            if (AfterIntChanged != null)
            {
                AfterIntChanged(this, EventArgs.Empty);
            }
        }
    }
    //RecieverExcClass
    public class RecieverExcClass
    {
        public void BeforeChanged(object sender,EventArgs e)
        {
            Console.WriteLine("Value is going to change.");
        }

        public void AfterChanged(object sender,EventArgs e)
        {
            Console.WriteLine("Value is changed now.");
        }
    }

    //Program Class
    public class ProgramExc
    {
        public  static void NewMain()
        {
            //sender Instance
            SenderExcClass sender = new SenderExcClass();
            //reciever Instance
            RecieverExcClass reciever = new RecieverExcClass();
            sender.MyInt = 2;
            //subscribing function to beforeintchanged event.
            sender.BeforeIntChanged += reciever.BeforeChanged;
            //subscribing functiion to afterintchanged event.
            sender.AfterIntChanged += reciever.AfterChanged;
            //changing value
            sender.MyInt = 3;
        }
    }

}
