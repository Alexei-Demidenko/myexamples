using System;
using System.Collections;

namespace IEnumerable_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel carModel = new CarModel();

            Console.WriteLine("\tIEnumerable_Foreach");
            foreach (var model in carModel)
            {
                Console.WriteLine(model);
            }

            Console.WriteLine("\n\tIEnumerator_While");
            IEnumerator ie = carModel.GetEnumerator();
            while (ie.MoveNext())
            {
                string item = (string)ie.Current;
                Console.WriteLine(item);
            }
            ie.Reset();

            Console.Read();
        }
    }
}
