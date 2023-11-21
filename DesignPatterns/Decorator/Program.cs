using Decorator.Models;
using Decorator.Models.Taxes;

Iss iss = new();
Iss issAndIcms = new(new Icms());

Order order = new(500);

var issTax = iss.Calculate(order);
var issIcmsTax = issAndIcms.Calculate(order);

Console.WriteLine(issTax);
Console.WriteLine(issIcmsTax);

Console.ReadKey();

// After executing the program the result must be: 30 and 80