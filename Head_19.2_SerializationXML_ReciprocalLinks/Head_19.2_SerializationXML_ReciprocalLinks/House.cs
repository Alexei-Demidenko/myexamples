using System;
using System.Collections.Generic;

namespace Head_19._2_SerializationXML_ReciprocalLinks
{
    [Serializable]
    internal class House
    {
        public List<Person> persons = new List<Person>();
        public House() { }
        public void AddPerson(Person person)
        {
            persons.Add(person);
            person.House = this;
        }
    }
}
