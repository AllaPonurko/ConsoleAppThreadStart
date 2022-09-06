using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleAppThreadStart
{
    public class MyThread
    {
        static public void Method()
        {
           
          Console.WriteLine("Поток запущен");
        }
        static public ThreadStart start = new ThreadStart(Method);
        public Thread T;
        public MyThread()
        {
            T = new Thread(start);
            T.Start();
           
        }
    }
}
