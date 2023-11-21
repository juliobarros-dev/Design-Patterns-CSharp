namespace Template_Method.Models
{
    internal class Item(string name, double value)
    {
        public string Name { get; private set; } = name;
        public double Value { get; private set; } = value;
    }
}
