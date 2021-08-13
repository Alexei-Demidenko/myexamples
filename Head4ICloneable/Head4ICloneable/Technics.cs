using System;

namespace Head4ICloneable
{
    internal struct Technics : ICloneable
    {
        internal string TypeTechnics;// тип автотехники
        internal string TypeFuel;// тип топлива
        internal int WeightCar; // Масса автотехники

        public Technics(string typeTechnics, string typeFuel, int weightCar) : this()
        {
            TypeTechnics = typeTechnics;
            TypeFuel = typeFuel;
            WeightCar = weightCar;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
