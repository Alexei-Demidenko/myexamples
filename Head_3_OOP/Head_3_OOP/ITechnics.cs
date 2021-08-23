namespace Head_3_OOP
{
    internal interface ITechnics
    {
        string TypeTechnics { get; } // тип автотехники
        string TypeFuel { get; } // тип топлива
        int Weight { get; } // Масса автотехники
        void Print(); // отправляем сообщение 
    }
}
