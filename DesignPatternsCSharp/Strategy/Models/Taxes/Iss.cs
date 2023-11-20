namespace Strategy.Models.Taxes
{
    internal class Iss
    {
        public double Calculate(Budget budget) => budget.Value * 0.06;
    }
}
