using Builder.Models;
using Builder.Utils;

InvoiceBuilder invoiceBuilder = new();

invoiceBuilder.AddCompanyName("Company");
invoiceBuilder.AddCompanyDocument("Document");
invoiceBuilder.AddInvoiceItem(new Item("Pen", 10.00));
invoiceBuilder.AddInvoiceItem(new Item("Pencil", 05.00));
invoiceBuilder.AddCreatedDate();
invoiceBuilder.AddComment("Some comment.");

// Now all the logic to create a new Invoice is inside the InvoiceBuilder and in our Program is easy to read and understand what parameters are needed to create an Invoice.
Invoice invoice = invoiceBuilder.Build();

Console.WriteLine(invoice.Name);

Console.ReadKey();