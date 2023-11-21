namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerMoreThanFiveHundred
    {
        public double Discount(Budget budget)
        {
            if (budget.Value > 500)
            {
                return budget.Value * 0.07;
            }

            return 0;
        }
    }
}
