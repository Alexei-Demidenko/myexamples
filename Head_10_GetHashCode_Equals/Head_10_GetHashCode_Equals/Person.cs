using System;

namespace Head_10_GetHashCode_Equals
{
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public DateTime Date_Birth { get; set; }
        public Other_info Other_Info { get; set; }
        public Person(string Surname, string Name, string Middle_name, DateTime Date_Birth, Other_info other_Info)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Middle_name = Middle_name;
            this.Date_Birth = Date_Birth;
            Other_Info = other_Info;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Person))
            {
                return false;
            }

            Person p = (Person)obj;

            return Surname == p.Surname && Name == p.Name && Middle_name == p.Middle_name
                     && Date_Birth == p.Date_Birth && Other_Info.Place_Birth == p.Other_Info.Place_Birth
                     && Other_Info.PassportID == p.Other_Info.PassportID;
        }
        public override int GetHashCode()
        {
            return Other_Info.GetHashCode() + Surname.GetHashCode() + Name.GetHashCode() + Middle_name.GetHashCode() + Date_Birth.GetHashCode();
        }
    }

    internal struct Other_info
    {
        public string Place_Birth { get; set; }
        public int PassportID { get; set; }
        public Other_info(string Place_Birth, int PassportID)
        {
            this.Place_Birth = Place_Birth;
            this.PassportID = PassportID;
        }
        public override int GetHashCode()
        {
            return PassportID.GetHashCode() + Place_Birth.GetHashCode();
        }
    }
}
