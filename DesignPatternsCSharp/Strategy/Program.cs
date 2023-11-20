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

// After executing the program the result must be: 50 and 30