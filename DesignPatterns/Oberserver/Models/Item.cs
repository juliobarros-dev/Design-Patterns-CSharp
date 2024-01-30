namespace Observer.Models
{
    public class Item(string name, double value)
    {
        public string Name { get; private set; } = name;
        public double Value { get; private set; } = value;
    }
}
