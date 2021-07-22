using System;

namespace Head_17_Extentions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skydiving skydiving = new();
            int ValueHeight = 4000;
            skydiving.Message1(ValueHeight);
            skydiving.Message2(ValueHeight);
            skydiving.Message3(ValueHeight);

            Random rnd = new();
            rnd.PrintRandom(rnd.Next(0, 5000));
        }
    }
}
