using System;

namespace Head_16_IDisposable_Using
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFile myFile = null;
            try
            {
                myFile = new MyFile(); // инициализируем
                Console.WriteLine("Создан неуправляемый ресурс intPtr и управляемый ресурсы handle:");
            }
            finally
            {
                if (myFile != null)
				{
                    myFile.Dispose();
                }
            }
            Console.WriteLine("\nСоздан неуправляемый ресурс intPtr и управляемый ресурсы handle, в конструкций using:");
            using MyFile file = new();
        }
    }
}
