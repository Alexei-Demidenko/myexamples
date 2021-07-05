using System;
using System.Runtime.InteropServices;

namespace Head_16_IDisposable_Using
{
    class MyFile : IDisposable
    {
        // 1000 байт неуправляемых ресурсов
        public IntPtr ptr = Marshal.AllocHGlobal(1000);
        public virtual void Dispose()
        {
            Console.WriteLine("Метод Disposed. Освобождаем неуправляемый ресурс ptr");
            // освобождаем ресурс
            Marshal.FreeHGlobal(ptr);
        }
    }
}
