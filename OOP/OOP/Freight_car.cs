using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Freight_car : Car
    {
        protected int lifting_capacity;

        public Freight_car(string Type_of_car, string Type_of_fuel, int Weight_car, int lifting_capacity) : base(Type_of_car, Type_of_fuel, Weight_car)
        {
            this.lifting_capacity = lifting_capacity;
        }
        public override void Print()
        {
            Console.WriteLine($"Тип автомобиля = {Type_of_car}\nТип топливо = {Type_of_fuel}\nВес автомобиля {Weight_car} кг.\nГрузоподемность = {lifting_capacity} тонн.");
        }
    }
}
