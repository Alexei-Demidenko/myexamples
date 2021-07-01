using System.ComponentModel;

namespace Head_14_INotifyPropertyChanged
{
    internal class Car_modelClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string car_model;
        public string Car_model
        {
            get { return car_model; }
            set
            {
                car_model = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Car_model)));
            }
        }
    }
}
