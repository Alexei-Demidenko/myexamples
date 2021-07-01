using System;
using System.Threading;


namespace Head_21_AutoResetEvent
{
    internal class Program
    {
        private static readonly AutoResetEvent waitHandler = new(true);
        private static int x;

        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                Thread myThread = new(Count);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }
            Console.ReadLine();
        }
        public static void Count()
        {
            waitHandler.WaitOne();           
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
            waitHandler.Set();
        }
    }
}
