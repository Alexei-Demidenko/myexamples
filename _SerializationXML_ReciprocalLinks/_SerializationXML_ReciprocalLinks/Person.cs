using System;
using System.Collections.Generic;
using System.Text;

namespace _SerializationXML_ReciprocalLinks
{
    [Serializable]
   public class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public House house { get; set; }
        public Person() { }
        public Person(string surname, string name, string middle_name)
        {
            Surname = surname;
            Name = name;
            Middle_name = middle_name;
        }
    }
}
