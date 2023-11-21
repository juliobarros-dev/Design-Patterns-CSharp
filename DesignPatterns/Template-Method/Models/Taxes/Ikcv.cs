using Template_Method.Abstractions;

namespace Template_Method.Models.Taxes
{
    internal class Ikcv : TaxBase
    {
        // Now each specific tax stablish it own rule and value of tax. The common code is encapsluted on the base class
        public override bool UseMaximumTaxRate(Order order) => order.Value > 500 && ItemValueMoreThanOneHundred(order);

        public override double MaximumTax(Order order) => order.Value * 0.1;

        public override double MinimumTax(Order order) => order.Value * 0.06;

        private static bool ItemValueMoreThanOneHundred(Order order) => order.Items.Any(x => x.Value > 100);
    }
}
