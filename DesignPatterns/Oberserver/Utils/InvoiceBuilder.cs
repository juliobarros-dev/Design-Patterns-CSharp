using Oberserver.Abstractions;
using Observer.Models;

namespace Observer.Utils
{
    public class InvoiceBuilder
    {
        public string Name { get; private set; } = string.Empty;
        public string Document { get; private set; } = string.Empty;
        public double Value { get; private set; }
        public double Tax { get; private set; }
        public IList<Item> Items { get; private set; } = new List<Item>();
        public string Comments { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }
        private IList<IInvoiceAction> _actions = new List<IInvoiceAction>();

        public InvoiceBuilder AddCompanyName(string name)
        {
            Name = name;
            return this;
        }

        public InvoiceBuilder AddCompanyDocument(string document)
        {
            Document = document;
            return this;
        }

        public InvoiceBuilder AddInvoiceItem(Item item)
        {
            Items.Add(item);
            Value += item.Value;
            Tax += item.Value * 0.05;
            return this;
        }

        public InvoiceBuilder AddComment(string comment) {
            Comments = comment;
            return this;
        }

        public InvoiceBuilder AddCreatedDate()
        {
            CreatedAt = DateTime.Now;
            return this;
        }

        public void AddAction(IInvoiceAction action)
        {
            _actions.Add(action);
        }

        public Invoice Build()
        {
            var invoice =  new Invoice(Name, Document, CreatedAt, Value, Tax, Items, Comments);

            foreach (var action in _actions)
            {
                action.Execute(invoice);
            }

            return invoice;
        }
    }
}
