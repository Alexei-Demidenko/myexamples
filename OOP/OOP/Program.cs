using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Freight_car freih_car = new Freight_car("Грузовой", "Дизель", 3500, 10);
            Price_discount price = new Price_discount(freih_car.Type_of_car, freih_car.Type_of_fuel, freih_car.Weight_car, 10, 5000);
            price.Print();
            price.price = 1500;
            price.Print();
            Passenger passenger = new Passenger("Пассажирский", "Бензин", 3800, 35, 18000);
            passenger.Print();
        }
    }
}
