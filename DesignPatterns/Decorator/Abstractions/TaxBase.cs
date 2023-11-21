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
            // With the constructor without parameter, now the AnotherTax can be null and is not necessary to instantiate a new Tax everytime. This verification
            // Will prevent null reference exception
            if (AnotherTax is null) return 0;

            return AnotherTax.Calculate(order);
        }
    }
}
