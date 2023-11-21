using Chain_of_Responsability.Models;
using Chain_of_Responsability.Services;

DiscountCalculator calculator = new();

Budget budget = new(250);

budget.AddItems(new Item("Pen", 500));
budget.AddItems(new Item("Pencil", 500));
budget.AddItems(new Item("Paper", 500));
budget.AddItems(new Item("Notebook", 500));
budget.AddItems(new Item("Tablet", 500));
budget.AddItems(new Item("Phone", 500));

double discounts = calculator.Calculate(budget);

Console.WriteLine(discounts);

Console.ReadKey();

// After executing the program the result must be: 25