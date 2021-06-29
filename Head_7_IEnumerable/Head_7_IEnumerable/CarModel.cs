using System.Collections;

namespace Head_7_IEnumerable
{
    internal class CarModel : IEnumerable
    {
        private readonly string[] Model = { "Mercedes-Benz", "Audi", "BMW ", "Nissan ", "Volkswagen", "Skoda" };
        public IEnumerator GetEnumerator()
        {
            return new CarModelEnumerator(Model);
        }
    }
}
