using System;

namespace Head_9_IComparable
{
    internal class Car : IComparable<Car>
    {
        public string Model_of_car { get; set; }
        public double Engine_volume { get; set; }
        public DateTime Year_of_issue { get; set; }
        public int CompareTo(Car p)
        {
            return Engine_volume.CompareTo(p.Engine_volume);
        }
    }
}
