using System;
using System.Collections;

namespace Head_7_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel carModel = new();

            Console.WriteLine("\tIEnumerable_Foreach");
            foreach (object model in carModel)
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
        }
    }
}
