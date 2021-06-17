using System;
using System.ComponentModel;

namespace _INotifyPropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            Car_modelClass sample = new Car_modelClass();
            sample.PropertyChanged += new PropertyChangedEventHandler(sample_PropertyChanged);
            while (true)
            {
                Console.WriteLine($"Введите марку авто: ");
                sample.Car_model = Console.ReadLine();
            }
        }
        static void sample_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Car_modelClass sample = (Car_modelClass)sender;
            Console.WriteLine($"Значение свойства {e.PropertyName} было изменено! Новое значение: {sample.Car_model}\n");
        }
        public class Car_modelClass : INotifyPropertyChanged
        {

            public event PropertyChangedEventHandler PropertyChanged;

            string car_model;
            public string Car_model
            {
                get { return car_model; }
                set
                {
                    car_model = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Car_model"));
                }
            }

        }
    }
}
