using System;
using System.Threading;

namespace Head_21_Threading_Mutex
{
    internal class DecThread
    {
        // В этом потоке переменная SharedRes.Count декрементируется,
        private readonly int num;
        public Thread Thrd;
        public DecThread(string name, int n)
        {
            Thrd = new Thread(new ThreadStart(Run));
            num = n;
            Thrd.Name = name;
            Thrd.Start();
        }
        // Точка входа в поток,
        void Run()
        {
            Console.WriteLine(Thrd.Name + " ожидает мьютекс.");
            // Получить мьютекс.
            SharedRes.Mtx.WaitOne();
            Console.WriteLine(Thrd.Name + " получает мьютекс.");
            for (int i = 0; i < num; i++)
            {
                Thread.Sleep(500);
                SharedRes.Count--;
                Console.WriteLine($"В потоке {Thrd.Name } SharedRes.Count = {SharedRes.Count}");
            }
            Console.WriteLine(Thrd.Name + " освобождает мьютекс.");
            // Освободить мьютекс.
            SharedRes.Mtx.ReleaseMutex();
        }
    }
}
