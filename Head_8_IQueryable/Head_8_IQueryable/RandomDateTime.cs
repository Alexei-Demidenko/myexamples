using System;

namespace Head_8_IQueryable
{
    internal class RandomDateTime
    {
        public DateTime Start { get; set; }
        public Random gen;
        public int range;
        public RandomDateTime()
        {
            Start = new DateTime(1935, 1, 1);
            gen = new Random();
            range = (DateTime.Today - Start).Days;
        }
        public DateTime Next()
        {
            return Start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
    }
}
