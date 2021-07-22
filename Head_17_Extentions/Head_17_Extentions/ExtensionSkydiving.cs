using System;

namespace Head_17_Extentions
{
    internal static class ExtensionSkydiving
    {
        internal static void Message3(this Skydiving skydiving, int height)
        {
            Console.WriteLine($"\nЕсли спрыгнуть с парашютом падая на голове, средняя скорость свободного падения будет =270 км/ч.," +
                $"и первые {height - 1000} м. преодалейте примерно за {(height - 1000) * 3.6 / 270} сек.");
        }
    }
}
