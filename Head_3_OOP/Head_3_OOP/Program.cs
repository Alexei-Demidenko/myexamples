
namespace Head_3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageCar car = new()
            {
                TypeTechnics = "Легковой автомобиль",
                TypeFuel = "Бензин",
                WeightCar = 1500
            };

            SpecialTechnics special = new()
            {
                TypeTechnics = "Спецтехника",
                TypeFuel = "Дизель",
                NameTechnics = "Экскаватор",
                WeightCar = 3500
            };

            ITechnics[] tehnics = new ITechnics[] { car, special };
            foreach (var tehnic in tehnics)
            {
                tehnic.Print();
            }
        }
    }
}
