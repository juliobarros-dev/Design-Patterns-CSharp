using Builder.Models;

namespace Builder.Utils
{
    internal class InvoiceBuilder
    {
        public string Name { get; private set; } = string.Empty;
        public string Document { get; private set; } = string.Empty;
        public double Value { get; private set; }
        public double Tax { get; private set; }
        public IList<Item> Items { get; private set; } = new List<Item>();
        public string Comments { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }

        public void AddCompanyName(string name) => Name = name;
        public void AddCompanyDocument(string document) => Document = document;
        public void AddInvoiceItem(Item item)
        {
            Items.Add(item);
            Value += item.Value;
            Tax += item.Value * 0.05;
        }
        public void AddComment(string comment) => Comments = comment;
        public void AddCreatedDate() => CreatedAt = DateTime.Now;

        public Invoice Build()
        {
            return new Invoice(Name, Document, CreatedAt, Value, Tax, Items, Comments);
        }
    }
}
