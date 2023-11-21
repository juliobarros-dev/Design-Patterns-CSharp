namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerFiveItems
    {
        public double Discount(Budget budget)
        {
            if (budget.Items.Count > 5)
            {
                return budget.Value * 0.1;
            }

            return 0;
        }
    }
}
