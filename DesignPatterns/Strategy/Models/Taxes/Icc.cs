using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Icc : ITax
    {
        public double Calculate(double value)
        {
            // Now we created a new tax with a more complexity rule to calculate it's value without the need to change anything on our calculator

            return value switch
            {
                < 1000 => value * 0.05,
                < 3000 => value * 0.07,
                _ => (value * 0.08) + 30,
            };
        }
    }
}
