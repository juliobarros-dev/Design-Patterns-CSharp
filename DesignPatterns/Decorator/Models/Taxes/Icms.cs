using Decorator.Abstractions;

namespace Decorator.Models.Taxes
{
    internal class Icms : TaxBase
    {
        public Icms() : base() { }

        public Icms(TaxBase anotherTax) : base(anotherTax) { }

        public override double Calculate(Order order)
        {
            return order.Value * 0.1 + AnotherTaxValue(order);
        }
    }
}
