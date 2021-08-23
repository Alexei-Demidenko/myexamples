using System;

namespace Head_14._1_Events
{
    internal class Jumper
    {
        public delegate void SkydiverHandler();
        public event SkydiverHandler Notify;
        internal void Height(int height)
        {
            if (height is 3900 or 1000 or 100)
            {
                Notify?.Invoke();
            }
            else
            {
                Console.WriteLine($"Ты находишся на высоте :{height} м.");
            }
        }
    }
}
