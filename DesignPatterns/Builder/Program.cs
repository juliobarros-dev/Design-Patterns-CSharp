using Builder.Models;

IList<Item> items = new List<Item>();

double invoiceValue = 0;

foreach (var item in items)
{
    invoiceValue += item.Value;
}

double tax = invoiceValue * 0.05;

Invoice invoice = new("Receipt", "Document", DateTime.Now, invoiceValue, tax, items, "Comments");

// Look how complex is to instantiate our Invoice class due to all informations need on its constructor. That's the problem that will be resolved with Builder Patter.