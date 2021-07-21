using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Head_16_IDisposable_Using
{
    internal class MyFile : IDisposable
    {
        // 1000 байт неуправляемых ресурсов
        public IntPtr intPtr = Marshal.AllocHGlobal(1000);
        //  управляемый ресурс
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // освобождаем управляемые ресурсы
                    handle.Dispose();
                    Console.WriteLine("Управляемый ресурс handle освобожден!");
                }
                // освобождаем неуправляемые ресурсы
                Marshal.FreeHGlobal(intPtr);
                Console.WriteLine("Неуправляемый ресурс - intPtr освобожден!");
                disposed = true;
            }
        }
        // финализатор
        ~MyFile()
        {
            Dispose(false);
        }
    }
}
