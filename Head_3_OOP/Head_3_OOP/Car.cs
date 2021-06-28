
namespace Head_3_OOP
{
    public abstract class Car : ITechnics
    {
        public string Type_of_Technics { get; set; }
        public string Type_of_fuel { get; set; }
        public int Weight_car { get; set; }
        public abstract void Print();
    }
}
