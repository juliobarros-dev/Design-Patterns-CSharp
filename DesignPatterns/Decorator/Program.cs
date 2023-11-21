using Decorator.Models;
using Decorator.Models.Taxes;

Iss iss = new();
Iss issAndIcms = new(new Icms());
Iss issAndIcmsAndIkcv = new(new Icms(new Ikcv()));

Order order = new(500);

var issTax = iss.Calculate(order);
var issIcmsTax = issAndIcms.Calculate(order);
var issIcmsIkcvTax = issAndIcmsAndIkcv.Calculate(order);

Console.WriteLine(issTax);
Console.WriteLine(issIcmsTax);
Console.WriteLine(issIcmsIkcvTax);

Console.ReadKey();

// After executing the program the result must be: 30, 80 e 95