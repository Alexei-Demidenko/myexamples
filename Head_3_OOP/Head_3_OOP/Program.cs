
namespace Head_3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageCar car = new()
            {
                Type_of_Technics = "Легковой автомобиль",
                Type_of_fuel = "Дизель",
                Weight_car = 1500
            };

            SpecialTechnics special = new()
            {
                Type_of_Technics = "Спецтехника",
                Type_of_fuel = "Дизель",
                NameTechnics = "Экскаватор",
                Weight_car = 3500
            };

            ITechnics[] tehnics = new ITechnics[] { car, special };
            foreach (var tehnic in tehnics)
            {
                tehnic.Print();
            }
        }
    }
}
