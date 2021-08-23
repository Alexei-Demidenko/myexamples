
using System;
using System.Threading;

namespace Head_14._1_Events
{
    internal class Program
    {
        private static readonly Jumper _handler = new();
        internal static void Main(string[] args)
        {
            _handler.Notify += Message1;
            for (var i = 4000; i > 0; i -= 100)
            {
                switch (i)
                {
                    case 3900:
                        _handler.Height(i);
                        _handler.Notify -= Message1;
                        _handler.Notify += Message2;
                        break;
                    case 1000:
                        _handler.Height(i);
                        _handler.Notify -= Message2;
                        _handler.Notify += Message3;
                        break;
                    case 100:
                        _handler.Height(i);
                        _handler.Notify -= Message3;
                        break;
                    default:
                        _handler.Height(i);
                        Thread.Sleep(50);
                        break;
                }
            }
        }
        internal static void Message1()
        {
            Console.WriteLine("\nПоздравляем! Ты спрыгнул с парашютом.\n");
            Thread.Sleep(50);
        }
        internal static void Message2()
        {
            Console.WriteLine("\nНе забудьте открыть парашют!\n");
            Thread.Sleep(50);
        }
        public static void Message3()
        {
            Console.WriteLine("\nПоздравляем! Ты приземлился!\nНадеемся всё прошло удачно.");
        }

    }
}
