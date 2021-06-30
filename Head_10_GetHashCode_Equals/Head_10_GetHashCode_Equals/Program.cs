using System;

namespace Head_10_GetHashCode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Other_info ot_info = new("Бутор", 0123456);
            Other_info ot_info1 = new("Тирасполь", 789456);
            Person person1 = new("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), ot_info);
            Person person2 = new("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), ot_info);
            Person person3 = new("Соломоненко", "Анастасия", "Васильевна", new DateTime(1991, 12, 31), ot_info1);

            Console.WriteLine($"Метод Equals: person1 == person2 = {person1.Equals(person2)}");
            Console.WriteLine($"Метод Equals: person1 == person3 = {person1.Equals(person3)}");
            Console.WriteLine($"Метод GetHashCode: person1 = {person1.GetHashCode()}");
            Console.WriteLine($"Метод GetHashCode: person2 = {person2.GetHashCode()}");
            Console.WriteLine($"Метод GetHashCode: ot_info = {ot_info.GetHashCode()}");
            Console.WriteLine($"Метод GetHashCode: ot_info1 = {ot_info1.GetHashCode()}");
        }
    }
}
