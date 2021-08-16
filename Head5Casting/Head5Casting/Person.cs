using System;

namespace Head5Casting
{
    internal class Person
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }

        public static explicit operator Person(string surnameName)
        {
            try
            {
                var arrayName = surnameName.Split(new char[] { ' ', ',', '.', ':' });
                var person = new Person { FirstName = arrayName[0], LastName = arrayName[1] };
                return person;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            throw new Exception($"Не удалось преобразовать строку: {surnameName} в Person.");
        }
        public override int GetHashCode() => $"{FirstName} {LastName}".GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() != GetType()) return false;
            var person = (Person)obj;
            return person != null && (FirstName == person.FirstName && LastName == person.LastName);
        }
        internal void Print(string exemplarName)
        {
            Console.WriteLine($"{exemplarName}: {FirstName} {LastName}");
        }
    }
}