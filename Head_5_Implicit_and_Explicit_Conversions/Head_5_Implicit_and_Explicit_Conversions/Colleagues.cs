using System;

namespace Head_5_Implicit_and_Explicit_Conversions
{
    internal class Colleagues : Person
    {
        public string Position { get; set; }
        public string Hobby { get; set; }
        public new void Print()
        {
            Console.WriteLine($"Человека зовут:{Surname} {Name}, его должность: {Position}, увлекается {Hobby}.");
        }
    }
}
