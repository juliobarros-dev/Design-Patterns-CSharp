namespace Chain_of_Responsability.Models
{
    internal class Order(double value)
    {
        internal double Value { get; private set; } = value;
        internal IList<Item> Items { get; private set; } = new List<Item>();

        public void AddItems(Item item)
        {
            Items.Add(item);
        }
    }
}
