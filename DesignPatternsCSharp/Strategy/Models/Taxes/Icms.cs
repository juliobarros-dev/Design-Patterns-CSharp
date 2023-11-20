using Strategy.Abstractions;

namespace Strategy.Models.Taxes
{
    internal class Icms : ITax
    {
        public double Calculate(double value) => value * 0.1;
    }
}
