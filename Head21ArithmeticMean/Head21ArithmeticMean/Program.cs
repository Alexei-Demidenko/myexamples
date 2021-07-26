using System;

namespace Head21ArithmeticMean
{
    class Program
    {
        private static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            int[] ArrayCount = { 10000, 100000 };          
            Console.WriteLine("\tПараллельное вычисления средней арифметическое(Parallel.ForEach):");
            foreach (int item in ArrayCount)
            {
                ArithmeticMean.ParallelForEachArithmeticMean(item);
            }
            Console.WriteLine("\n\tПараллельное вычисления средней арифметическое(Parallel.For):");
            foreach (int item in ArrayCount)
            {
                ArithmeticMean.ParallelForArithmeticMean(item);
            }
            Console.WriteLine("\n\tСредней арифметическое без параллельных вычислений:");
            foreach (int item in ArrayCount)
            {
                ArithmeticMean.Arithmetic(item);
            }
        }
    }
}
