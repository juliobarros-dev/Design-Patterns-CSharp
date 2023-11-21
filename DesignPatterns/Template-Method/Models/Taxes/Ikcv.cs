using Template_Method.Abstractions;

namespace Template_Method.Models.Taxes
{
    internal class Ikcv : TaxBase
    {
        public override bool UseMaximumTaxRate(Order order) => order.Value > 500 && ItemValueMoreThanOneHundred(order);

        public override double MaximumTax(Order order) => order.Value * 0.1;

        public override double MinimumTax(Order order) => order.Value * 0.06;

        private static bool ItemValueMoreThanOneHundred(Order order) => order.Items.Any(x => x.Value > 100);
    }
}
