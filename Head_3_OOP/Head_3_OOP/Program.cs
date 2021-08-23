
namespace Head_3_OOP
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            MessageCar car = new()
            {
                TypeTechnics = "Легковой автомобиль",
                TypeFuel = "Бензин",
                Weight = 1500
            };

            SpecialTechnics special = new()
            {
                TypeTechnics = "Спецтехника",
                TypeFuel = "Дизель",
                NameTechnics = "Экскаватор",
                Weight = 3500
            };

            var technician = new ITechnics[] { car, special };
            foreach (var technical in technician)
            {
                technical.Print();
            }
        }
    }
}
