using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Icc : ITax
    {
        public double Calculate(Budget budget)
        {
            // Now we created a new tax with a more complexity rule to calculate it's value without the need to change anything on our calculator

            return budget.Value switch
            {
                < 1000 => budget.Value * 0.05,
                < 3000 => budget.Value * 0.07,
                _ => (budget.Value * 0.08) + 30,
            };
        }
    }
}
