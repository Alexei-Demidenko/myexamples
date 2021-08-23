using System;

namespace Head_17_Extentions
{
    internal static class ExtensionInt
    {
        internal static void PositiveNegativeNumbers(this int intNumber)
        {
            if (intNumber > 0)
            {
                Console.WriteLine($"Число: {intNumber} - положительные.");
            }
            else if (intNumber < 0)
            {
                Console.WriteLine($"Число: {intNumber} - отрицательные.");
            }
            else
            {
                Console.WriteLine($"Число: {intNumber} - равно нулю.");
            }
        }
    }
}
