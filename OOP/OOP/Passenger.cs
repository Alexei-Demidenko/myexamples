using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Passenger : Car
    {
        protected int number_of_seats;
        protected int mileage;
        public Passenger(string Type_of_car, string Type_of_fuel, int Weight_car, int number_of_seats, int mileage) : base(Type_of_car, Type_of_fuel, Weight_car)
        {
            this.number_of_seats = number_of_seats;
            this.mileage = mileage;
        }
        public override void Print()
        {
            Console.WriteLine($"Тип автомобиля = {Type_of_car}\nТип топливо = {Type_of_fuel}\nВес автомобиля {Weight_car} кг.\nКоличество посадочных мест  = {number_of_seats}\nПробег = {mileage} км.\n");
        }
    }
}
