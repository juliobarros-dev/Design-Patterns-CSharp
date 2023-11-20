namespace Strategy.Models.Taxes
{
    internal class Icms
    {
        public double Calculate(Budget budget) => budget.Value * 0.1;
    }
}
