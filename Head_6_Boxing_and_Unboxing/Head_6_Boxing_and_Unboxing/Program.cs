using System;

namespace Head_6_Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortValue = -32768;
            object objectValue = shortValue; // boxing
            Console.WriteLine($"Произошла упаковка shortValue в objectValue.\tobjectValue={objectValue}");

            try
            {
                int intValue = (int)objectValue; // попытка распаковки
                Console.WriteLine($"\nПроизошла распаковка objectValue в intValue.\tintValue={intValue}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"\nПри попытке распаковка objectValue в intValue произошла ошибка: {e.Message}");
            }

            try
            {
                shortValue = (short)objectValue; ; // попытка распаковки
                Console.WriteLine($"\nПроизошла распаковка objectValue в shortValue.\tshortValue={shortValue}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"\nПри попытке распаковка objectValue в shortValue произошла ошибка: {e.Message}");
            }

            //Упаковка структуры в интерфейс
            Console.WriteLine("\nУпаковка структуры в интерфейс:");
            Test test = new() { IntValue = 10 };
            Console.WriteLine($"test.IntValue = {test.IntValue}");
            IExample iTest = test; // упаковка структуры
            iTest.SetValue(1);
            iTest.PrintValue();
            Console.WriteLine($"test.IntValue = {test.IntValue}");
        }

        interface IExample
        {
            void PrintValue();
            void SetValue(int i);
        }
        struct Test : IExample
        {
            public int IntValue { get; set; }
            public void PrintValue()
            {
                Console.WriteLine($"IntValue в методе PrintValue = {IntValue}");
            }
            public void SetValue(int value)
            {
                IntValue = value;
            }
        }
    }
}
