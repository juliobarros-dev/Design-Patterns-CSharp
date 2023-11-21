using Template_Method.Abstractions;

namespace Template_Method.Models.Taxes
{
    internal class Icpp : ITax
    {
        public double Calculate(Order order)
        {
            // At this point we have 2 classes that are taxes and have similar behavior, they both check a condition to decide either maximum or minum tax.
            if (order.Value >= 500) return order.Value * 0.07;

            return order.Value * 0.05;
        }
    }
}
