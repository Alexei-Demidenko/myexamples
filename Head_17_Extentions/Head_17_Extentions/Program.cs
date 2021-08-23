using System;

namespace Head_17_Extentions
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Skydiving skydiving = new();
            const int valueHeight = 4000;
            skydiving.Message1(valueHeight);
            skydiving.Message2(valueHeight);
            skydiving.Message3(valueHeight);

            Random rnd = new();
            rnd.PrintRandom();

            var intValue = 15;
            intValue.PositiveNegativeNumbers();
        }
    }
}
