using System;
using System.Collections.Generic;
using System.Text;

namespace IComparable
{
    class Car:IComparable<Car>
    {
        public string Model_of_car { get; set; }
        public double Engine_volume { get; set; }
        public DateTime year_of_issue { get; set; }
        public int CompareTo(Car p)
        {
            return this.Engine_volume.CompareTo(p.Engine_volume);
        }
      
    }
}
