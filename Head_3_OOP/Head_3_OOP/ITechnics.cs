namespace Head_3_OOP
{
    internal interface ITechnics
    {
        string TypeTechnics { get; } // тип автотехники
        string TypeFuel { get; } // тип топлива
        int WeightCar { get; } // Масса автотехники
        abstract void Print(); // отправляем сообщение 
    }
}
