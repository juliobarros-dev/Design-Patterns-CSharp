using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Iss : ITax
    {
        public double Calculate(double value) => value * 0.06;
    }
}
