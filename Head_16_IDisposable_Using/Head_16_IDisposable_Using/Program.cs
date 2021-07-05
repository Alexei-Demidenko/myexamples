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
                Console.WriteLine("Создан объект класса MyFile!");
            }
            finally
            {
                if (myFile != null)
				{
                    myFile.Dispose();
                }
            }

            Console.WriteLine("\nСоздаем объект класса MyFile в конструкций using");
            using MyFile file = new();                        
        }
    }
}
