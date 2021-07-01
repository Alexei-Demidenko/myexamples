using System;
using System.Threading;

namespace Head_21_Threading_Mutex
{
    internal class IncThread
    {
        // В этом потоке переменная SharedRes.Count инкрементируется
        private readonly int num;
        public Thread Thrd;
        public IncThread(string name, int n)
        {
            Thrd = new Thread(Run);
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }

        // Точка входа в поток,
        private void Run()
        {
            Console.WriteLine(Thrd.Name + " ожидает мьютекс.");
            // Получить мьютекс.
            SharedRes.Mtx.WaitOne();
            Console.WriteLine(Thrd.Name + " получает мьютекс.");
            for (int i = 0; i < num; i++)
            {
                Thread.Sleep(500);
                SharedRes.Count++;
                Console.WriteLine($"В потоке {Thrd.Name } SharedRes.Count = {SharedRes.Count}");
            }
            Console.WriteLine(Thrd.Name + " освобождает мьютекс.");
            // Освободить мьютекс.
            SharedRes.Mtx.ReleaseMutex();
        }
    }
}
