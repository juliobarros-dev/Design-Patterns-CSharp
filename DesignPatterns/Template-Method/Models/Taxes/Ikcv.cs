using Template_Method.Abstractions;

namespace Template_Method.Models.Taxes
{
    internal class Ikcv : ITax
    {
        public double Calculate(Order order)
        {
            if (order.Value > 500 && ItemValueMoreThanOneHundred(order)) return order.Value * 0.1;

            return order.Value * 0.06;
        }

        private static bool ItemValueMoreThanOneHundred(Order order) => order.Items.Any(x => x.Value > 100);
    }
}
