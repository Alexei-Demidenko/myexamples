using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), "Бутор", 0123456);
            Person person2 = new Person("Соломоненко", "Анастасия", "Васильевна", new DateTime(1999, 12, 31), "Тирасполь", 789456);

            Dictionary<Person, string> WorkDictionary = new Dictionary<Person, string>
            {
                {person1, "УВО МВД ПМР"},
                {person2, "Dex"}
            };
            
            while (true)
            {
                bool PersonExists = false;
                Person person3=new Person();
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
                
                int num;
                bool isNum = int.TryParse(Console.ReadLine(), out num);
                if (isNum)
                {
                    person3.PassportID =num;
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Введенный номер паспорта не соответсвует формату!\n");
                    goto PassID;
                }

                foreach (var item in WorkDictionary)
                {
                    if (item.Key.Surname == person3.Surname && item.Key.Name == person3.Name && item.Key.Middle_name == person3.Middle_name
                        && item.Key.Place_Birth == person3.Place_Birth && item.Key.PassportID == person3.PassportID)
                    {
                        Console.WriteLine($"Сотрудник найден, его место работы - {item.Value}\n\n");
                        PersonExists = true;
                    }
                }
                if (!PersonExists)
                {
                    Console.WriteLine("Такого человека нет в словаре.\n\n");
                }                               
            }
        }
    }
}
