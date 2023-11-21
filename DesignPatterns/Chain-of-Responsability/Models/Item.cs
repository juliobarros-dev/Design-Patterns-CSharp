namespace Chain_of_Responsability.Models
{
    internal class Item(string name, double value)
    {
        public string Name { get; private set; } = name;
        public double Value { get; private set; } = value;
    }
}
