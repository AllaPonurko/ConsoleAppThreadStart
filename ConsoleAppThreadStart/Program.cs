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
                Console.WriteLine("Запущен новый поток");
            }
            void NewMethod()
            {
                ThreadStart start = new ThreadStart(Method);
                Thread T = new Thread(start);
                T.Start();
                Console.WriteLine("Запущен дочерний поток");
            }
            ThreadStart start = new ThreadStart(NewMethod);
            Thread my = new Thread(start);
            my.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Поток ожидает завершения работы!");
            my.Join();
            Console.WriteLine("Поток завершенил работу!");
        }
    }
}
