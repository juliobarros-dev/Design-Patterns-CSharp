using Decorator.Abstractions;

namespace Decorator.Models.Taxes
{
    internal class Ikcv : TaxBase
    {
        public Ikcv() : base() { }

        public Ikcv(TaxBase anotherTax) : base(anotherTax) { }

        public override double Calculate(Order order)
        {
            return order.Value * 0.03 + AnotherTaxValue(order);
        }
    }
}
