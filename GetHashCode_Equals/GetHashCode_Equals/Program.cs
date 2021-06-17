using System;

namespace GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Other_info ot_info = new Other_info("Бутор", 0123456);
            Other_info ot_info1 = new Other_info("Тирасполь", 789456);
            Person person1 = new Person("Демиденко","Алексей","Владимирович", new DateTime(1991, 12, 31), ot_info);
            Person person2 = new Person("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), ot_info);
            Person person3 = new Person("Соломоненко", "Анастасия", "Васильевна", new DateTime(1991, 12, 31), ot_info1);
            
            Console.WriteLine($"Метод Equals: person1 == person2 = {person1.Equals(person2)}");
            Console.WriteLine($"Метод Equals: person1 == person3 = {person1.Equals(person3)}");
            Console.WriteLine($"Метод GetHashCode: ot_info = {ot_info.GetHashCode()}");
            Console.WriteLine($"Метод GetHashCode: ot_info1 = {ot_info1.GetHashCode()}");            
        }
    }
}
