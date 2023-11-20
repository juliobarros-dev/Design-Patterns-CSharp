using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Icms : ITax
    {
        public double Calculate(Budget budget) => budget.Value * 0.1;
    }
}
