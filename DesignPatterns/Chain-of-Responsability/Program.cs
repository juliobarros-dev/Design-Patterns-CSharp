using Chain_of_Responsability.Models;
using Chain_of_Responsability.Services;

Order order = new(250);

order.AddItems(new Item("Pen", 500));
order.AddItems(new Item("Pencil", 500));
order.AddItems(new Item("Paper", 500));
order.AddItems(new Item("Notebook", 500));

double discounts = DiscountCalculator.Calculate(order);

Console.WriteLine(discounts);

Console.ReadKey();

// After executing the program the result must be: 125