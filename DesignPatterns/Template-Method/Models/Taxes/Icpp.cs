using Template_Method.Abstractions;

namespace Template_Method.Models.Taxes
{
    internal class Icpp : TaxBase
    {
        // At this point we are using a common class that implements the commom code and the specific classes are responsible to stablish their own rule of charge.
        public override bool UseMaximumTaxRate(Order order) => order.Value >= 500;

        public override double MaximumTax(Order order) => order.Value * 0.07;

        public override double MinimumTax(Order order) => order.Value * 0.05;
    }
}
