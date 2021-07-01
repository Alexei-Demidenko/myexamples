using System;
using System.Threading;

namespace Head_21_Threading_Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            IncThread mt1 = new("Инкрементирующий Поток", 5);
            mt1.Thrd.Join();
            Thread.Sleep(1);
            DecThread mt2 = new("Декрементирующий Поток", 5);
            mt2.Thrd.Join();
        }
    }
}
