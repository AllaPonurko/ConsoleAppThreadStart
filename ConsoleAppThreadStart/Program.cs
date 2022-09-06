using System;
using System.Threading;

namespace ConsoleAppThreadStart
{
    class Program
    {
        static void Main(string[] args)
        {
            void Method()
            {
                ThreadStart start = new ThreadStart(NewMethod);
                Thread T = new Thread(start);
                T.Start();
                Console.WriteLine("Запущен дочерний поток "+T.ManagedThreadId+" "+T.ThreadState);
                Thread.Sleep(1000);
                Console.WriteLine("Поток " + T.ManagedThreadId + " " + T.ThreadState);
            }
            void NewMethod()
            {
                Console.WriteLine("Запущен новый поток " );
            }
            ThreadStart start = new ThreadStart(Method);
            Thread my = new Thread(start);
            my.Start();
            Console.WriteLine("Текущий поток " +my.ManagedThreadId + " " + my.ThreadState);
            Console.WriteLine("Поток ожидает завершения работы!");
            Thread.Sleep(1000);
            Console.WriteLine("Поток " + my.ManagedThreadId + " " + my.ThreadState);
        }
    }
}
