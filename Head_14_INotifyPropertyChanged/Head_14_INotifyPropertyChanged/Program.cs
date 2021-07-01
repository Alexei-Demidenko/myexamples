using System;
using System.ComponentModel;

namespace Head_14_INotifyPropertyChanged
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car_modelClass sample = new();
            sample.PropertyChanged += new PropertyChangedEventHandler(Sample_PropertyChanged);
            while (true)
            {
                Console.WriteLine($"Введите марку авто: ");
                sample.Car_model = Console.ReadLine();
            }
        }

        private static void Sample_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Car_modelClass sample = (Car_modelClass)sender;
            Console.WriteLine($"Значение свойства {e.PropertyName} было изменено! Новое значение: {sample.Car_model}\n");
        }
    }
}
