using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Price_discount : Freight_car
    {
        const int discount = 1500;
        internal int price, discountprice;
        public Price_discount(string Type_of_car, string Type_of_fuel, int Weight_car, int lifting_capacity, int price) : base(Type_of_car, Type_of_fuel, Weight_car, lifting_capacity)
        {
            this.price = price;
        }
        private void Discount(int price, int discount)
        {
            if (price < discount)
                discountprice = price - (price / 100 * 3);
            if (price == discount)
                discountprice = price - (price / 100 * 5);
            else
                discountprice = price - (price / 100 * 10);
        }
        public new void Print()
        {

            base.Print();
            Discount(price, discount);
            Console.WriteLine($"Цена = {price}\nЦена со скидкой = {discountprice}.\n");
        }
    }
}
