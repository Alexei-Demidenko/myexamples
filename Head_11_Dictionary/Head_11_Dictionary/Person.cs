using System;

namespace Head_11_Dictionary
{
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateBirth { get; set; }
        public string PlaceBirth { get; set; }
        public int PassportId { get; set; }
        public Person()
        {
        }
        public Person(string surname, string name, string middleName, DateTime dateBirth, string placeBirth, int passportId)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            DateBirth = dateBirth;
            PlaceBirth = placeBirth;
            PassportId = passportId;
        }
        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return Surname.CompareTo(person.Surname) == 0
                   && Name.CompareTo(person.Name) == 0
                   && MiddleName.CompareTo(person.MiddleName) == 0
                   && PlaceBirth.CompareTo(person.PlaceBirth) == 0
                   && PassportId.CompareTo(person.PassportId) == 0;
        }
        public override int GetHashCode()
        {
            return Surname.GetHashCode() + Name.GetHashCode() + MiddleName.GetHashCode() + PlaceBirth.GetHashCode() + PassportId.GetHashCode();
        }
    }
}
