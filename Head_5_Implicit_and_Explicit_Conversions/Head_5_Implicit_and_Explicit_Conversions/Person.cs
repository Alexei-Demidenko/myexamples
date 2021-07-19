using System;

namespace Head_5_Implicit_and_Explicit_Conversions
{
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine($"Человека зовут:{Surname} {Name}.");
        }
    }
}
