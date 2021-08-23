using System;

namespace Head_17_Extentions
{
    internal static class ExtensionRandom
    {
        internal static void PrintRandom(this Random rndRandom)
        {
            Console.WriteLine($"\nМетод расширения PrintRandom класса Random:");
            Console.WriteLine($"Сгенерировано случайное число: {rndRandom.Next()}.\n");
        }
    }
}
