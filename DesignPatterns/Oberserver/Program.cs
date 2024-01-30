using Oberserver.Utils;
using Observer.Models;
using Observer.Utils;

InvoiceBuilder invoiceBuilder = new();

invoiceBuilder
    .AddCompanyName("Company")
    .AddCompanyDocument("Document")
    .AddInvoiceItem(new Item("Pen", 10.00))
    .AddInvoiceItem(new Item("Pencil", 05.00))
    .AddCreatedDate()
    .AddComment("Some comment.");

invoiceBuilder.AddAction(new InvoiceDao());
invoiceBuilder.AddAction(new EmailSender());
invoiceBuilder.AddAction(new SmsSender());

Invoice invoice = invoiceBuilder.Build();

Console.WriteLine(invoice.Name);
Console.WriteLine(invoice.Value);
Console.WriteLine(invoice.Tax);

Console.ReadKey();