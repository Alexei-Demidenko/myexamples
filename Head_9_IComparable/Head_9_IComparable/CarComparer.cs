using System.Collections.Generic;

namespace Head_9_IComparable
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            return c1.Engine_volume < c2.Engine_volume ? 1 : c1.Engine_volume > c2.Engine_volume ? -1 : 0;
        }
    }
}
