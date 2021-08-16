﻿using System;
using System.Diagnostics;

namespace Head_6_Boxing_and_Unboxing
{
    internal class Program
    {
        private static void Main()
        {
            short shortValue = -32768;
            var timeBoxingUnboxing = new Stopwatch();

            timeBoxingUnboxing.Start();
            object objectValue = shortValue; // boxing
            timeBoxingUnboxing.Stop();
            Console.WriteLine($"Упаковка shortValue в objectValue. Потрачено {timeBoxingUnboxing.ElapsedTicks} тактов на выполнение.");
            timeBoxingUnboxing.Reset();

            timeBoxingUnboxing.Start();
            shortValue = (short)objectValue; // unboxing
            timeBoxingUnboxing.Stop();
            Console.WriteLine($"Разпаковка objectValue в shortValue. Потрачено {timeBoxingUnboxing.ElapsedTicks} тактов на выполнение.");
            timeBoxingUnboxing.Reset();

            try
            {
                var intValue = (int)objectValue; // попытка распаковки
                Console.WriteLine($"\nПроизошла распаковка objectValue в intValue.\tintValue={intValue}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"\nПри попытке распаковка objectValue в intValue произошла ошибка: {e.Message}");
            }

            try
            {
                shortValue = (short)objectValue; // попытка распаковки
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

        internal interface IExample
        {
            void PrintValue();
            void SetValue(int i);
        }

        internal struct Test : IExample
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
