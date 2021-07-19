using System;

namespace Head_3_OOP
{
    internal class MessageCar : Car
    {
        //класс MessageCar наследует и переопределяет метод Print от класса Car,
        //который был унаследован от интерфейса ITechnics но небыл переопределен в класе Car
        //использовал этот класс чтобы показать глубину иерархии.
        public override void Print()
        {
            Console.WriteLine($"Тип автотехники = {TypeTechnics}\nТип топливо = {TypeFuel}\n" +
                $"Вес автомобиля {WeightCar} кг.\n");
        }
    }
}
