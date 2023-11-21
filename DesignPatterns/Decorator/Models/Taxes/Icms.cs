using Decorator.Abstractions;

namespace Decorator.Models.Taxes
{
    internal class Icms(TaxBase anotherTax) : TaxBase(anotherTax)
    {
        public override double Calculate(Order order)
        {
            return order.Value * 0.1 + AnotherTaxValue(order);
        }
    }
}
