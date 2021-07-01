using System;

namespace Head_19._2_SerializationXML_ReciprocalLinks
{
    [Serializable]
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public House House { get; set; }
        public Person() { }
        public Person(string surname, string name, string middle_name)
        {
            Surname = surname;
            Name = name;
            Middle_name = middle_name;
        }
    }
}
