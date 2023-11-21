using Decorator.Models;

namespace Decorator.Abstractions
{
    internal abstract class TaxBase(TaxBase anotherTax)
    {
        public TaxBase AnotherTax { get; set; } = anotherTax;

        public abstract double Calculate(Order order);

        protected double AnotherTaxValue(Order order)
        {
            return AnotherTax.Calculate(order);
        }
    }
}
