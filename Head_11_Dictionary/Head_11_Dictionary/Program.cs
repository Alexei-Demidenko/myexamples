using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Head_11_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new("Демиденко", "Алексей", "Владимирович", new DateTime(1990, 10, 11), "Бутор", 0123456);
            Person person2 = new("Соломоненко", "Анастасия", "Васильевна", new DateTime(1999, 12, 31), "Тирасполь", 789456);

            Dictionary<Person, string> workDictionary = new()
            {
                { person1, "УВО МВД ПМР" },
                { person2, "Dex" }
            };

            PersonList personList = new("Демиденко", "Алексей", "Владимирович", new DateTime(1990, 10, 11), "Бутор", 0123456, "УВО МВД ПМР");
            PersonList personList2 = new("Соломоненко", "Анастасия", "Васильевна", new DateTime(1999, 12, 31), "Тирасполь", 789456, "УВО МВД ПМР");
            List<PersonList> workList = new() { personList, personList2 };

            Random rnd = new();
            RandomDateTime date = new();
            for (var i = 0; i < 999998; i++)
            {
                Person person3 = new()
                {
                    Surname = Guid.NewGuid().ToString("n")[..10],
                    Name = Guid.NewGuid().ToString("n")[..10],
                    MiddleName = Guid.NewGuid().ToString("n")[..10],
                    DateBirth = date.Next(),
                    PlaceBirth = Guid.NewGuid().ToString("n")[..10],
                    PassportId = i
                };
                workDictionary[person3] = "ООО работа";

                personList2 = new(Guid.NewGuid().ToString("n")[..10],
                   Guid.NewGuid().ToString("n")[..10],
                   Guid.NewGuid().ToString("n")[..10],
                   date.Next(),
                   Guid.NewGuid().ToString("n")[..10],
                   i,
                   Guid.NewGuid().ToString("n")[..10]);

                workList.Add(personList2);

            }
            /* while (true)
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
            */

            Console.WriteLine("Ищем сотрудника в workDictionary:");
            var timeSearch = new Stopwatch();
            timeSearch.Start();
            if (workDictionary.TryGetValue(person1, out var employee))
            {
                Console.WriteLine($"Сотрудник найден, его место работы - {employee}");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден!");
            }
            timeSearch.Stop();
            Console.WriteLine($"Потрачено {timeSearch.ElapsedTicks} тактов на поиск сотрудника.\n");
            timeSearch.Reset();
            Console.WriteLine("Ищем сотрудника в workList:");
            timeSearch.Start();
            var personList3 = workList.Find(item => item.PassportId == personList.PassportId);
            if (personList3 != null)
            {
                Console.WriteLine($"Сотрудник найден, его место работы - {personList3.Employee}");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден!");
            }
            timeSearch.Stop();
            Console.WriteLine($"Потрачено {timeSearch.ElapsedTicks} тактов на поиск сотрудника.");
            timeSearch.Reset();
            // }
        }
    }
}
