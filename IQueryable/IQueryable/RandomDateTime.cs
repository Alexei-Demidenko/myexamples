using System;
using System.Collections.Generic;
using System.Text;

namespace IQueryable
{
    class RandomDateTime
    {
        public DateTime start { get; set; }
        public Random gen;
        public int range;

        public RandomDateTime()
        {
            start = new DateTime(1935, 1, 1);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60) );
        }
    }
}
