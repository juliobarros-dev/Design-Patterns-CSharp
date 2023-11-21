using Decorator.Models;

namespace Decorator.Abstractions
{
    internal abstract class TaxBase
    {
        public TaxBase? AnotherTax { get; set; }

        public TaxBase() { }

        public TaxBase(TaxBase anotherTax)
        {
            AnotherTax = anotherTax;
        }

        public abstract double Calculate(Order order);

        protected double AnotherTaxValue(Order order)
        {
            if (AnotherTax is null) return 0;

            return AnotherTax.Calculate(order);
        }
    }
}
