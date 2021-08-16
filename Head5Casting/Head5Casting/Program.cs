using System;

namespace Head5Casting
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var person1 = new Person { FirstName = "Алексей", LastName = "Демиденко" };
            person1.Print("person1");
            var person2 = (Person)"Алексей Демиденко";
            person2.Print("person2");
            Console.Write("Сравниваем экземпляр Person и текст при помощи оператора == : ");
            Console.WriteLine(person1 == (Person)"Алексей Демиденко");
            Console.Write("Сравниваем экземпляр Person и текст при помощи Equals() : ");
            Console.WriteLine(person1.Equals((Person)"Алексей Демиденко"));
        }
    }
}