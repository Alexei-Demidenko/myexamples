using System;
using System.Threading;

namespace Head_14._1_Events
{
    internal class ClassParachutist
    {
        public event Action Height = delegate { };
        internal void Jump()
        {
            Height += Handler.Message1;
            for (int i = 4000; i >0; i-=100)
            {   
                switch (i)
                {
                    case 3900:
                        Height?.Invoke();
                        Height -= Handler.Message1;
                        Height += Handler.Message2;
                        break;
                    case 1000:
                        Height?.Invoke();
                        Height -= Handler.Message2;
                        Height += Handler.Message3;
                        break;
                    case 100:
                        Height?.Invoke();
                        Height -= Handler.Message3;
                        break;
                    default:
                        Console.WriteLine($"Ты находишся на высоте :{i} м.");
                        break;
                }
                Thread.Sleep(50);
            }
        }
    }
}
