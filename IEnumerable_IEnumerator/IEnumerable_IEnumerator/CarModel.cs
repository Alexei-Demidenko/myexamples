using System.Collections;

namespace IEnumerable_IEnumerator
{
    class CarModel
    {
        string[] Model = { "Mercedes-Benz", "Audi", "BMW ", "Nissan ", "Volkswagen", "Skoda" };

        public IEnumerator GetEnumerator()
        {
            return new CarModelEnumerator(Model);
        }

    }
}