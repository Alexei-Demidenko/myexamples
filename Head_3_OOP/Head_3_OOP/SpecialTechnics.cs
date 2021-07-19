using System;

namespace Head_3_OOP
{
    internal class SpecialTechnics : ITechnics
    {
        public string TypeTechnics { get; set; }
        public string TypeFuel { get; set; }
        public string NameTechnics { get; set; } // название спецтехники
        public int WeightCar { get; set; }
        public void Print()
        {
            Console.WriteLine($"Тип автотехники = {TypeTechnics}\nНазвания = {NameTechnics}\n" +
                $"Тип топливо = {TypeFuel}\nВес автотехники {WeightCar} кг.\n");
        }
    }
}
