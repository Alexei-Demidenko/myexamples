namespace Head_3_OOP
{
    public abstract class Car : ITechnics
    {
        public string TypeTechnics { get; set; }
        public string TypeFuel { get; set; }
        public int Weight { get; set; }
        public abstract void Print();
    }
}
