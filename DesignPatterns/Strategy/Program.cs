using Strategy.Abstractions;
using Strategy.Models;
using Strategy.Models.Taxes;
using Strategy.Services;

ITax icms = new Icms();
ITax iss = new Iss();
ITax icc = new Icc();

Budget budget1 = new(500);
Budget budget2 = new(2000);
Budget budget3 = new(5000);

TaxCalculator.Calculate(budget1.Value, icms);
TaxCalculator.Calculate(budget1.Value, iss);
TaxCalculator.Calculate(budget1.Value, icc);
TaxCalculator.Calculate(budget2.Value, icc);
TaxCalculator.Calculate(budget3.Value, icc);

// After executing the program the result must be: 50, 30, 25, 140, 430