using Decorator.Abstractions;

namespace Decorator.Models.Taxes
{
    internal class Iss(TaxBase anotherTax) : TaxBase(anotherTax)
    {
        public override double Calculate(Order order)
        {
            return order.Value * 0.06 + AnotherTaxValue(order);
        }
    }
}
