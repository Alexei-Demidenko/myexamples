using System;

namespace Head_17_Extentions
{
    internal static class ExtensionRandom
    {
        internal static void PrintRandom(this Random skydiving, int RandomValue)
        {
            Console.WriteLine($"\nМетод расширения PrintRandom класса Random:");
            Console.WriteLine($"Сгенерировано случайное число: {RandomValue}.");
        }
    }
}
