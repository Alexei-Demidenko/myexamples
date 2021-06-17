using System;
using System.Threading;

namespace _ThreadPool
{
    class Program
    {
        static void Main()
        {
            int nWorkerThreads;
            int nCompletionThreads;
            ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
            Console.WriteLine($"Максимальное количество потоков: {nWorkerThreads}"+
                 $"\nПотоков ввода-вывода доступно: {nCompletionThreads}");
            for (int i = 0; i < 5; i++)
                ThreadPool.QueueUserWorkItem(JobForAThread);
            Thread.Sleep(3000);
            Console.ReadLine();
        }

        static void JobForAThread(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"цикл {i}, выполнение внутри потока из пула {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(50);
            }
        }
    }
}
