using System;

namespace Head_14._1_Events
{
    internal class Handler
    {
        public delegate void SkydiverHandler();
        public event SkydiverHandler Notify;
        internal void Height(int height)
        {
            switch (height)
            {
                case 3900:
                    Notify?.Invoke();
                    break;
                case 1000:
                    Notify?.Invoke();
                    break;
                case 100:
                    Notify?.Invoke();
                    break;
                default:
                    Console.WriteLine($"Ты находишся на высоте :{height} м.");
                    break;
            }
        }
    }
}
