using Decorator.Abstractions;

namespace Decorator.Models.Taxes
{
    internal class Iss : TaxBase
    {
        public Iss() : base() { }

        public Iss(TaxBase anotherTax) : base(anotherTax) { }

        public override double Calculate(Order order)
        {
            return order.Value * 0.06 + AnotherTaxValue(order);
        }
    }
}
