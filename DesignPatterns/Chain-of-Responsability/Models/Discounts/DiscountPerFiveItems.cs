using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerFiveItems : IDiscount
    {
        public IDiscount Next { get; set; }

        public double Discount(Budget budget)
        {
            if (budget.Items.Count > 5)
            {
                return budget.Value * 0.1;
            }

            // Now we are creating the chain because if the discount is not applied, it automatically calls the next Discount withut the need to know exactly what discount it will be
            return Next.Discount(budget);
        }
    }
}
