using Strategy.Abstractions;
using Strategy.Models;
using Strategy.Models.Taxes;
using Strategy.Services;

TaxCalculator taxCalculator = new();

ITax icms = new Icms();
ITax iss = new Iss();

Budget budget = new(500.00);

taxCalculator.Calculate(budget, icms);
taxCalculator.Calculate(budget, iss);
ITax icc = new Icc();

Budget budget1 = new(500);
Budget budget2 = new(2000);
Budget budget3 = new(5000);

taxCalculator.Calculate(budget1, icms);
taxCalculator.Calculate(budget1, iss);
taxCalculator.Calculate(budget1, icc);
taxCalculator.Calculate(budget2, icc);
taxCalculator.Calculate(budget3, icc);

// After executing the program the result must be: 50, 30, 25, 140, 430