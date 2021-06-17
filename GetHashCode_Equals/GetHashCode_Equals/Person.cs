using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_Equals
{
    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public DateTime Date_Birth { get; set; }        
        public Other_info other_Info { get; set; }
        public Person(string Surname, string Name, string Middle_name, DateTime Date_Birth, Other_info other_Info)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Middle_name = Middle_name;
            this.Date_Birth = Date_Birth;
            this.other_Info = other_Info;
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

            var p = (Person)obj;

            return (this.Surname == p.Surname && this.Name == p.Name && this.Middle_name == p.Middle_name
                     && this.Date_Birth==p.Date_Birth&&this.other_Info.Place_Birth==p.other_Info.Place_Birth
                     &&this.other_Info.PassportID==p.other_Info.PassportID);
        }
    }
    struct Other_info
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
          return (PassportID.GetHashCode() + Place_Birth.GetHashCode());
        }
    }
}
