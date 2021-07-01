using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Head_19._1_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new("Демиденко", "Алексей", "Владимирович", new DateTime(1991, 12, 31), "Бутор", 0123456);

            Serialization_BinaryFormatter(person1);
            Serialization_JsonSerializer(person1);
            Serialization_XMLSerializer(person1);
        }

        public static void Serialization_BinaryFormatter(Person person)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("\tОбъект сериализован BinaryFormatter");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new("people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                Print(newPerson);
            }
        }
        public static void Serialization_JsonSerializer(Person person)
        {
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine("\tОбъект сериализован JsonSerializer");
            Console.WriteLine(json);
            Person newPerson = JsonConvert.DeserializeObject<Person>(json);
            Print(newPerson);
        }

        public static void Serialization_XMLSerializer(Person person)
        {            
            XmlSerializer formatter = new(typeof(Person));
            // сериализация
            using (FileStream fs = new("person.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("\tОбъект сериализован XmlSerializer");
            }
            // десериализация 
            Person newPerson;
            using (FileStream fs = new("person.xml", FileMode.OpenOrCreate))
            {
                newPerson = (Person)formatter.Deserialize(fs);
                Print(newPerson);
            }
        }
        public static void Print(Person newPerson)
        {
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Фамилия: {newPerson.Surname}\nИмя: {newPerson.Name}\nОтчество: {newPerson.Middle_name}" +
                $"\nДата рождения: {newPerson.Date_Birth}\nМесто рождения: {newPerson.Place_Birth}\nНомер паспорта: {newPerson.PassportID}\n");
        }
    }
}
