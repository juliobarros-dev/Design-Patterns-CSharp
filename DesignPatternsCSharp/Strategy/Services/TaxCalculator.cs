using Strategy.Abstractions;
using Strategy.Models;

namespace Strategy.Services
{
    internal class TaxCalculator
    {
        public void Calculate(Budget budget, ITax tax)
        {
            // The Strategy pattern has been implemented, transforming our Tax Calculator to be independent of a particular tax, such as Iss or Icsm.
            // Instead, it now relies on the abstraction defined by the ITax interface.
            // The responsibility for calculating the tax is now delegated to the respective class that implements the ITax interface.
            // This design allows us to seamlessly add new taxes as needed, as long as they adhere to the ITax interface, without requiring modifications to the Calculator.

            double result = tax.Calculate(budget);
            Console.WriteLine(result);
        }
    }
}
