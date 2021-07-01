using System;
using System.Threading;

namespace Head_21_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.GetMaxThreads(out int nWorkerThreads, out int nCompletionThreads);
            Console.WriteLine($"Максимальное количество потоков: {nWorkerThreads}" +
                 $"\nПотоков ввода-вывода доступно: {nCompletionThreads}");
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(JobForAThread);
            }
            Thread.Sleep(3000);
            Console.ReadLine();
        }

        static void JobForAThread(object state)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"цикл {i}, выполнение внутри потока из пула {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(50);
            }
        }
    }
}
