
namespace Head_3_OOP
{
    interface ITechnics
    {
        string Type_of_Technics { get; } // тип автотехники
        string Type_of_fuel { get; } // тип топлива
        int Weight_car { get; } // Масса автотехники
        abstract void Print(); // отправляем сообщение 
    }
}
