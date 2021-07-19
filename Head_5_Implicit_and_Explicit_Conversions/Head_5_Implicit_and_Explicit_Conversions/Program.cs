using System;

namespace Head_5_Implicit_and_Explicit_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            short ShortValue = 3;
            int IntValue = ShortValue;       // Неявные преобразования           
            char CharValue = (char)ShortValue;  // Явные преобразования  

            Console.WriteLine($"ShortValue={ShortValue}\tIntValue={IntValue}\tCharValue={CharValue}");

            //checked=>исключение о переполнении
            try
            {
                byte ByteValue = checked((byte)(ShortValue + IntValue));
                Console.WriteLine($"\nByteValue={ByteValue}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Person person = new();
            Friend friend = new();
            Colleagues colleagues = new();

            //ключевое слово is 
            if (friend is Person) // проверяем объект на принадлежность к типу               
            {
                person = friend; // приводим friend к типу Person
                Console.WriteLine("\nПреобразование friend к типу Person прошла успешно.");
            }
            else
            {
                Console.WriteLine("\nНе удалось преобразование  friend к типу Person.");
            }

            //ключевое слово as
            colleagues = person as Colleagues;// попытка приведения person к типу Colleagues
            if (colleagues == null)
            {
                Console.WriteLine("\nНе удалось преобразование person к типу Colleagues.");
            }
            else
            {
                Console.WriteLine("\nПреобразование person к типу Colleagues прошла успешно.\n");
            }

            //отлавливании исключения InvalidCastException
            try
            {
                colleagues = (Colleagues)person;
                Console.WriteLine("\nПреобразование person к типу Colleagues прошла успешно");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"\nНе удалось преобразование person к типу Colleagues -> {ex.Message}");
            }
        }
    }
}
