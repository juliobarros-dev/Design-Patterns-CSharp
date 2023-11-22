using Builder.Models;
using Builder.Utils;

InvoiceBuilder invoiceBuilder = new();

invoiceBuilder
    .AddCompanyName("Company")
    .AddCompanyDocument("Document")
    .AddInvoiceItem(new Item("Pen", 10.00))
    .AddInvoiceItem(new Item("Pencil", 05.00))
    .AddCreatedDate()
    .AddComment("Some comment.");

Invoice invoice = invoiceBuilder.Build();

Console.WriteLine(invoice.Name);
Console.WriteLine(invoice.Value);
Console.WriteLine(invoice.Tax);

Console.ReadKey();

// After executing the program the result must be: Company, 15 and 0.75