using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Iss : ITax
    {
        public double Calculate(Budget budget) => budget.Value * 0.06;
    }
}
