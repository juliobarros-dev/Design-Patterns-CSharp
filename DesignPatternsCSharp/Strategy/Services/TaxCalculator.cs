using Strategy.Abstractions;
using Strategy.Models;

namespace Strategy.Services
{
    internal static class TaxCalculator
    {
        public static void Calculate(double value, ITax tax)
        {
            // The Strategy pattern has been implemented, transforming our Tax Calculator to be independent of a particular tax, such as Iss or Icsm.
            // Instead, it now relies on the abstraction defined by the ITax interface.
            // The responsibility for calculating the tax is now delegated to the respective class that implements the ITax interface.
            // This design allows us to seamlessly add new taxes as needed, as long as they adhere to the ITax interface, without requiring modifications to the Calculator.

            double result = tax.Calculate(value);
            Console.WriteLine(result);
        }
    }
}
