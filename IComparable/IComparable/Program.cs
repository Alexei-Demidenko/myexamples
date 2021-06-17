using System;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Model_of_car = "Mercedes", Engine_volume = 2.5, year_of_issue = new DateTime(1991, 12, 31) };
            Car car2 = new Car { Model_of_car = "Chevrolet", Engine_volume = 3.5, year_of_issue = new DateTime(2000, 10, 31) };
            Car car3 = new Car { Model_of_car = "Mitsubishi", Engine_volume = 2.0, year_of_issue = new DateTime(2010, 1, 31) };
            Car car4 = new Car { Model_of_car = "Volkswagen", Engine_volume = 1.6, year_of_issue = new DateTime(2020, 12, 31) };
            
            Car[] arraycar1 = new Car[] { car1, car2, car3, car4 };

            Console.WriteLine("\tIComparable по возростанию объёма");
            Array.Sort(arraycar1);
            foreach (var c in arraycar1)
            {
                Console.WriteLine($"{c.Model_of_car}\t - {c.Engine_volume}\t\t - {c.year_of_issue.ToString("d")}");
            }

            Console.WriteLine("\n\tIComparer по убыванию объёма");
            Array.Sort(arraycar1, new CarComparer());
            foreach (var c in arraycar1)
            {
                Console.WriteLine($"{c.Model_of_car}\t - {c.Engine_volume}\t\t - {c.year_of_issue.ToString("d")}");
            }                       
            
        }
      
            
       
    }
}
