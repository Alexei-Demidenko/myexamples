using System;
using System.Threading;

namespace Threading_Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            IncThread mt1 = new IncThread("Инкрементирующий Поток", 5);
            mt1.Thrd.Join();
            Thread.Sleep(1);
            DecThread mt2 = new DecThread("Декрементирующий Поток", 5);
            mt2.Thrd.Join();
        }
    }
}
// общий ресурс(переменная Count), а также мьютекс (Mtx), управляющий доступом к ней.
class SharedRes
{
    public static int Count = 0;
    public static Mutex Mtx = new Mutex();
}
// В этом потоке переменная SharedRes.Count инкрементируется
class IncThread
{
    int num;
    public Thread Thrd;
    public IncThread(string name, int n)
    {
        Thrd = new Thread(this.Run);
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
            SharedRes.Count++;
            Console.WriteLine($"В потоке {Thrd.Name } SharedRes.Count = {SharedRes.Count}");
        }
        Console.WriteLine(Thrd.Name + " освобождает мьютекс.");
        // Освободить мьютекс.
        SharedRes.Mtx.ReleaseMutex();
    }
}

// В этом потоке переменная SharedRes.Count декрементируется,
class DecThread
{
    int num;
    public Thread Thrd;
    public DecThread(string name, int n)
    {
        Thrd = new Thread(new ThreadStart(this.Run));
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
