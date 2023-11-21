using Decorator.Models;
using Decorator.Models.Taxes;

// At this stage, we have the flexibility to combine multiple taxes, ensuring that each selected tax is applied, but we still have a problem with the implementation
// This way we are stuck in a loop that always need a new Tax so we can instantiate our classes
Iss iss = new(new Icms());
Order order = new(500);

var issIcmsTax = iss.Calculate(order);

Console.WriteLine(issIcmsTax);

Console.ReadKey();