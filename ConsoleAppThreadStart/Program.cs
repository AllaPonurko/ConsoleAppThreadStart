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
                Console.WriteLine("Запущен дочерний поток");
            }
            ThreadStart start = new ThreadStart(Method);
            
            Thread my = new Thread(start);
            my.Start();
            Thread.Sleep(1000);
            Thread T = new Thread(start);
            T.Start();
            Thread.Sleep(1000);
            my.Join();
            Console.WriteLine("Поток ожидает завершения работы!");
            
        }
    }
}
