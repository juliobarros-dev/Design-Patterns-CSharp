﻿using Observer.Models;

namespace Observer.Utils
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

        private void SendInvoiceByEmail(Invoice invoice)
        {
            Console.WriteLine("Invoice sent by e-mail.");
        }

        private void SendInvoiceBySms(Invoice invoice)
        {
            Console.WriteLine("Invoice sent by SMS.");
        }

        private void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine("Invoice saved.");
        }

        public Invoice Build()
        {
            var invoice =  new Invoice(Name, Document, CreatedAt, Value, Tax, Items, Comments);

            SaveInvoice(invoice);
            SendInvoiceByEmail(invoice);
            SendInvoiceBySms(invoice);

            return invoice;
        }
    }
}
