using System;

namespace Head_11_Dictionary
{
    internal class PersonList : Person
    {
        public string Employee { get; set; }
        public PersonList(string surname, string name, string middleName, DateTime dateBirth, string placeBirth, int passportId, string employee) : base(surname, name, middleName, dateBirth, placeBirth, passportId)
        {
            Employee = employee;
        }
    }
}
