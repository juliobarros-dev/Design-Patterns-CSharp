using Template_Method.Models;

namespace Template_Method.Abstractions
{
    internal abstract class TaxBase : ITax
    {
        public double Calculate(Order order)
        {
            if (UseMaximumTaxRate(order)) return MaximumTax(order);

            return MinimumTax(order);
        }

        public abstract bool UseMaximumTaxRate(Order order);
        public abstract double MaximumTax(Order order);
        public abstract double MinimumTax(Order order);
    }
}
