using System;

namespace Head_5_Implicit_and_Explicit_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortValue = 3;
            int intValue = shortValue;       // Неявные преобразования           
            char charValue = (char)shortValue;  // Явные преобразования  

            Console.WriteLine($"shortValue={shortValue}\tintValue={intValue}\tcharValue={charValue}");

            //checked=>исключение о переполнении
            try
            {
                byte byteValue = checked((byte)(shortValue + intValue));
                Console.WriteLine($"\nbyteValue={byteValue}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //ключевое слово is
            object objectValue = new object();
            if (objectValue is Example) // проверяем объект на принадлежность к типу
            {
                Example example1 = (Example)objectValue; // приводим объект o к типу Example
                Console.WriteLine("\nПреобразование objectValue к типу Example прошла успешно");
            }
            else
            {
                Console.WriteLine("\nНе удалось преобразование objectValue к типу Example");
            }

            //ключевое слово as
            Example example2 = new();
            object objectValue2 = example2 as object;      // попытка приведения example2 к типу object
            if (objectValue2 == null)
            {
                Console.WriteLine("\nНе удалось преобразование Example example2 к типу object");
            }
            else
            {
                Console.WriteLine("\nПреобразование Example example2 к типу object прошла успешно");
            }

            //отлавливании исключения InvalidCastException
            try
            {
                object objectValue3 = (object)example2;
                Console.WriteLine("\nПреобразование Example example2 к типу object прошла успешно");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        class Example { } // Пустой класс Example
    }
}
