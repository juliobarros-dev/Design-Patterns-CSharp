using Template_Method.Models;
using Template_Method.Models.Taxes;

Order order = new(1000);

Icpp icpp = new();
Ikcv ikcv = new();

var icppTax = icpp.Calculate(order);
var ikcvTax = ikcv.Calculate(order);

Console.WriteLine(icppTax);
Console.WriteLine(ikcvTax);

Console.ReadKey();

// After executing the program the result must be: 70 and 60