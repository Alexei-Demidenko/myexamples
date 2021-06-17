using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace _SerializationXML_ReciprocalLinks
{
    class Program
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
                Console.WriteLine("Serialization Failed");
                Console.WriteLine(serExc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine($"The serialization operation failed: {exc.Message} StackTrace: {exc.StackTrace}");
            }

            finally
            {
                Console.WriteLine("\nPress <Enter> to exit.");
                Console.ReadLine();
            }

        }
        public static void WriteObject(string fileName)
        {
            Console.WriteLine("Создание объекта Person и House и сериализация House.");
            Person person1 = new Person("Демиденко", "Алексей", "Владимирович");
            House house = new House();
            house.AddPerson(person1);
            var dcss = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var dcs = new DataContractSerializer(typeof(House), dcss);
            FileStream writer = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

            dcs.WriteObject(writer, house);
            Console.WriteLine("Объект успешно сериализован!\n");
            writer.Close();
        }
        public static void ReadObject(string fileName)
        {
            Console.WriteLine("Объект десериализован:");
            FileStream fs = new FileStream(fileName,
            FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            DataContractSerializer ser = new DataContractSerializer(typeof(House));
            // Десериализовать данные и прочитать их из экземпляра
            House deserializedHouse =(House)ser.ReadObject(reader, true);
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
