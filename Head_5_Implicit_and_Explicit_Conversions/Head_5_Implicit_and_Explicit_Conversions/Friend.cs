using System;

namespace Head_5_Implicit_and_Explicit_Conversions
{
    internal class Friend : Person
    {
        public string Hobby { get; set; }
        public new void Print()
        {
            Console.WriteLine($"Человека зовут:{Surname} {Name}, его хобби : {Hobby}.");
        }
    }
}
