using System;

namespace Head4ICloneable
{
    internal class Program
    {
        internal static void Main()
        {
            // ICloneable ValueType поверхностное копирование
            Technics technic1 = new("Легковой", "Бензин", 980);
            var technic2 = (Technics)technic1.Clone();
            technic2.TypeTechnics = "Спецтранспорт";
            technic2.WeightCar = 3600;
            Console.WriteLine($"\ttechnic1\nТип автотехники = {technic1.TypeTechnics}\n" +
                              $"Тип топливо = {technic1.TypeFuel}\nВес автотехники {technic1.WeightCar} кг.\n");
            Console.WriteLine($"\n\ttechnic2\nТип автотехники = {technic2.TypeTechnics}\n" +
                              $"Тип топливо = {technic2.TypeFuel}\nВес автотехники {technic2.WeightCar} кг.\n");

            //Глубокое копирование класса Cars c ссылкой на объект OwnerCar
            Cars car1 = new() { TypeTechnics = "Легковой", WeightCar = 950, OwnerCar = new OwnerCar { IdOwner = "222" } };
            Print("car1", car1);
            var car2 = car1.Clone();
            Print("car2", (Cars)car2);
            car1.TypeTechnics = "Спецтехника";
            car1.OwnerCar.IdOwner = "111";
            Console.WriteLine("\tПосле изменения car1:");
            Print("car1", car1);
            Print("car2", (Cars)car2);
        }
        public static void Print(string name, Cars car)
        {
            Console.WriteLine($"{name}\nTypeTechnics={car.TypeTechnics}\nWeightCar={car.WeightCar}\nOwner={car.OwnerCar.IdOwner}\n");
        }
    }
}