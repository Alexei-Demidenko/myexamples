using System;
using System.Collections.Generic;
using System.Text;

namespace IComparable
{
    class CarComparer: IComparer<Car>
    {
        public int Compare(Car c1, Car c2)
        {
            if (c1.Engine_volume < c2.Engine_volume)
                return 1;
            else if (c1.Engine_volume > c2.Engine_volume)
                return -1;
            else
                return 0;
           
        }
    }
}
