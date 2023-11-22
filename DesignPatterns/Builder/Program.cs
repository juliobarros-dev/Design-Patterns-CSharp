using Builder.Models;
using Builder.Utils;

InvoiceBuilder invoiceBuilder = new();

// Now our builder has a Fluent Interface
invoiceBuilder
    .AddCompanyName("Company")
    .AddCompanyDocument("Document")
    .AddInvoiceItem(new Item("Pen", 10.00))
    .AddInvoiceItem(new Item("Pencil", 05.00))
    .AddCreatedDate()
    .AddComment("Some comment.");

// Now all the logic to create a new Invoice is inside the InvoiceBuilder and in our Program is easy to read and understand what parameters are needed to create an Invoice.
Invoice invoice = invoiceBuilder.Build();

Console.WriteLine(invoice.Name);

Console.ReadKey();