using System;
using System.Collections.Generic;

namespace Head_11_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), "Бутор", 0123456);
            Person person2 = new("Соломоненко", "Анастасия", "Васильевна", new DateTime(1999, 12, 31), "Тирасполь", 789456);

            Dictionary<Person, string> WorkDictionary = new()
            {
                { person1, "УВО МВД ПМР" },
                { person2, "Dex" }
            };

            while (true)
            {
                Person person3 = new();
                Console.WriteLine("Введите фамилию:");
                person3.Surname = Console.ReadLine();

                Console.WriteLine("Введите имя:");
                person3.Name = Console.ReadLine();

                Console.WriteLine("Введите отчество:");
                person3.Middle_name = Console.ReadLine();

                Console.WriteLine("Введите место рождения:");
                person3.Place_Birth = Console.ReadLine();

            PassID:
                Console.WriteLine("Введите номер паспорта:");

                bool isNum = int.TryParse(Console.ReadLine(), out int num);
                if (isNum)
                {
                    person3.PassportID = num;
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Введенный номер паспорта не соответсвует формату!\n");
                    goto PassID;
                }

                // ищем сотрудника  
                if (WorkDictionary.TryGetValue(person3, out string employee))
                {
                    Console.WriteLine($"Сотрудник найден, его место работы - {employee}\n\n");
                }
                else
                {
                    Console.WriteLine("Сотрудник не найден!\n\n");
                }
            }
        }
    }
}
