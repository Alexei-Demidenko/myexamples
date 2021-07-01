using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Head_19._2_SerializationXML_ReciprocalLinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "house.xml";
                WriteObject(fileName);
                ReadObject(fileName);
            }
            catch (SerializationException serExc)
            {
                Console.WriteLine("Ошибка сериализации.");
                Console.WriteLine(serExc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Не удалось выполнить операцию сериализации: {exc.Message} Трассировки стека: {exc.StackTrace}");
            }

            finally
            {
                Console.WriteLine("\nНажмите <Enter> для выхода.");
                Console.ReadLine();
            }
        }
        public static void WriteObject(string fileName)
        {
            Console.WriteLine("Создание объекта Person и House и сериализация House.");
            Person person1 = new("Демиденко", "Алексей", "Владимирович");
            House house = new();
            house.AddPerson(person1);
            DataContractSerializerSettings dcss = new() { PreserveObjectReferences = true };
            DataContractSerializer dcs = new(typeof(House), dcss);
            FileStream writer = new(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

            dcs.WriteObject(writer, house);
            Console.WriteLine("Объект успешно сериализован!\n");
            writer.Close();
        }
        public static void ReadObject(string fileName)
        {
            Console.WriteLine("Объект десериализован:");
            FileStream fs = new(fileName, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            DataContractSerializer ser = new(typeof(House));
            // Десериализовать данные и прочитать их из экземпляра
            House deserializedHouse = (House)ser.ReadObject(reader, true);
            reader.Close();
            fs.Close();
            for (int i = 0; i < deserializedHouse.persons.Count; i++)
            {
                Console.WriteLine($"Фамилия: {deserializedHouse.persons[i].Surname}\n" +
                    $"Имя: {deserializedHouse.persons[i].Name}\n" +
                    $"Отчество: {deserializedHouse.persons[i].Middle_name}");
            }
        }
    }
}
