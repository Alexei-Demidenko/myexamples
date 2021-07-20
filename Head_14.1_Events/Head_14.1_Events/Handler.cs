using System;
using System.Threading;

namespace Head_14._1_Events
{
    internal class Handler
    {
        internal static void Message1()
        {            
            Console.WriteLine("\nПоздравляем! Ты спрыгнул с парашютом.\n");
            Thread.Sleep(100);
        }
        internal static void Message2()
        {
            Console.WriteLine("\nНе забудьте открыть парашют!\n");
            Thread.Sleep(100);
        }
        internal static void Message3()
        {
            Console.WriteLine("\nПоздравляем! Ты приземлился!\nНадеемся всё прошло удачно.");
            Thread.Sleep(100);
        }
    }
}
