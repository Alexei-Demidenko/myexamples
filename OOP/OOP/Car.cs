using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Car
    {
        public string Type_of_car { get; set; }
        public string Type_of_fuel { get; set; }
        public int Weight_car { get; set; }
        public Car(string Type_of_car, string Type_of_fuel, int Weight_car)
        {
            this.Type_of_car = Type_of_car;
            this.Type_of_fuel = Type_of_fuel;
            this.Weight_car = Weight_car;
        }
        public abstract void Print();
    }
}
