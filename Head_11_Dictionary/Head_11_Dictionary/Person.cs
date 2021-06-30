using System;

namespace Head_11_Dictionary
{
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public DateTime Date_Birth { get; set; }
        public string Place_Birth { get; set; }
        public int PassportID { get; set; }
        public Person()
        {
        }
        public Person(string Surname, string Name, string Middle_name, DateTime Date_Birth, string Place_Birth, int PassportID)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Middle_name = Middle_name;
            this.Date_Birth = Date_Birth;
            this.Place_Birth = Place_Birth;
            this.PassportID = PassportID;
        }
        public override bool Equals(Object obj)
        {
            Person person = obj as Person;
            return Surname.CompareTo(person.Surname) == 0
                   && Name.CompareTo(person.Name) == 0
                   && Middle_name.CompareTo(person.Middle_name) == 0
                   && Place_Birth.CompareTo(person.Place_Birth) == 0
                   && PassportID.CompareTo(person.PassportID) == 0;
        }
        public override int GetHashCode()
        {
            return Surname.GetHashCode() + Name.GetHashCode() + Middle_name.GetHashCode() + Place_Birth.GetHashCode() + PassportID.GetHashCode();
        }
    }
}
