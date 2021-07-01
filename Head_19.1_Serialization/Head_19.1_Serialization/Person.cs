using System;

namespace Head_19._1_Serialization
{
    [Serializable]
    public class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public DateTime Date_Birth { get; set; }
        public string Place_Birth { get; set; }
        public int PassportID { get; set; }
        public Person()
        { }
        public Person(string Surname, string Name, string Middle_name, DateTime Date_Birth, string Place_Birth, int PassportID)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Middle_name = Middle_name;
            this.Date_Birth = Date_Birth;
            this.Place_Birth = Place_Birth;
            this.PassportID = PassportID;
        }
    }
}
