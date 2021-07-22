using System;

namespace Head_17_Extentions
{
    internal class Skydiving
    {
        internal void Message1(int height)
        {
            Console.WriteLine($"Вы находитесь на высоте : {height} м.");
        }
        internal void Message2(int height)
        {
            Console.WriteLine($"\nЕсли спрыгнуть с парашютом падая на пусе, средняя скорость свободного падения будет =180 км/ч.," +
                $"и первые {height - 1000} м. преодалейте примерно за {(height - 1000) * 3.6 / 180} сек.");
        }
    }
}
