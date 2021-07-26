using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Head21ArithmeticMean
{
    internal class ArithmeticMean
    {       
        internal static Stopwatch Time = new();
        internal static void Arithmetic(int ArrayCount)
        {
            int[] Array = new int[ArrayCount];
            int ArraySum = 0;
            Random rnd = new();
            Time.Start();
            for (int i = 0; i < ArrayCount; i++)
            {
                Array[i] = rnd.Next(1, 100);
                ArraySum += Array[i];
            }
            ArraySum /= ArrayCount;
            Time.Stop();
            Print(ArraySum, Time.Elapsed);
        }
        internal static void ParallelForEachArithmeticMean(int ArrayCount)
        {
            int[] Array = new int[ArrayCount];
            int BatchSize = 100;
            int ArraySum = 0;
            Random rnd = new();
            Time.Start();
            Parallel.ForEach(Partitioner.Create(0, Array.Length, BatchSize), range =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    Array[i] = rnd.Next(1, 100);
                    ArraySum += Array[i];
                }
            });
            ArraySum /= ArrayCount;
            Time.Stop();
            Print(ArraySum, Time.Elapsed);
        }
        internal static void ParallelForArithmeticMean(int ArrayCount)
        {
            int[] Array = new int[ArrayCount];
            int ArraySum = 0;
            Random rnd = new();
            Time.Start();
            Parallel.For(0, Array.Length, n => { Array[n] = rnd.Next(1, 100); ArraySum += Array[n]; });
            ArraySum /= ArrayCount;
            Time.Stop();
            Print(ArraySum, Time.Elapsed);
        }
        private static void Print(int ArithmeticMean, TimeSpan Time)
        {
            Console.WriteLine($"Среднея арифметическое: {ArithmeticMean}");
            Console.WriteLine($"Cреднее арифметическое сгенерирована и подсчитана за {Time} миллисек.");
        }
    }
}
