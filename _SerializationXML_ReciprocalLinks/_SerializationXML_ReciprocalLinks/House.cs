using System;
using System.Collections.Generic;

namespace _SerializationXML_ReciprocalLinks
{
    [Serializable]
    public class House
    {
        public List<Person> persons = new List<Person>();
        public House() { }
        public void AddPerson(Person person)
        {
            persons.Add(person);
            person.house = this;
        }
    }
}
