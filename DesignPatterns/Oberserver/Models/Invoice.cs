namespace Observer.Models
{
    internal class Invoice(string name, string document, DateTime createdAt, double value, double tax, IList<Item> items, string commments)
    {
        public string Name { get; set; } = name;
        public string Document { get; set; } = document;
        public DateTime CreatedAt { get; set; } = createdAt;
        public double Value { get; set; } = value;
        public double Tax { get; set; } = tax;
        public IList<Item> Items { get; set; } = items;
        public string Comments { get; set; } = commments;
    }
}
