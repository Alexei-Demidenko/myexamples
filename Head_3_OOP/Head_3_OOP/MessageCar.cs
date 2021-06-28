using System;

namespace Head_3_OOP
{
    class MessageCar : Car
    {
        public override void Print()
        {
            Console.WriteLine($"Тип автотехники = {Type_of_Technics}\nТип топливо = {Type_of_fuel}\n" +
                $"Вес автомобиля {Weight_car} кг.\n");
        }
    }
}
