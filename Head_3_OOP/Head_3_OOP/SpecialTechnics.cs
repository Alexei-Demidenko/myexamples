using System;

namespace Head_3_OOP
{
    class SpecialTechnics : ITechnics
    {
        public string Type_of_Technics { get; set; }
        public string Type_of_fuel { get; set; }
        public string NameTechnics { get; set; } // название спецтехники
        public int Weight_car { get; set; }
        public void Print()
        {
            Console.WriteLine($"Тип автотехники = {Type_of_Technics}\nНазвания = {NameTechnics}\n" +
                $"Тип топливо = {Type_of_fuel}\nВес автотехники {Weight_car} кг.\n");
        }
    }
}
