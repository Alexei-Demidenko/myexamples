using System;

namespace Head4ICloneable
{
    internal class Cars : ICloneable
    {
        internal string TypeTechnics;// тип авто
        internal int WeightCar; // масса автотехники
        public OwnerCar OwnerCar;// Id владельца

        public object Clone()
        {
            var ownerCar = new OwnerCar { IdOwner = this.OwnerCar.IdOwner };
            return new Cars
            {
                TypeTechnics = this.TypeTechnics,
                WeightCar = this.WeightCar,
                OwnerCar = ownerCar
            };
        }
    }
}
