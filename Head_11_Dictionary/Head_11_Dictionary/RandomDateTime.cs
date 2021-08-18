using System;

namespace Head_11_Dictionary
{
    internal class RandomDateTime
    {
        public DateTime Start { get; set; }
        public Random Gen;
        public int Range;
        public RandomDateTime()
        {
            Start = new DateTime(1935, 1, 1);
            Gen = new Random();
            Range = (DateTime.Today - Start).Days;
        }
        public DateTime Next()
        {
            return Start.AddDays(Gen.Next(Range)).AddHours(Gen.Next(0, 24)).AddMinutes(Gen.Next(0, 60)).AddSeconds(Gen.Next(0, 60));
        }
    }
}
