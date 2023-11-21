using Chain_of_Responsability.Models;

namespace Chain_of_Responsability.Services
{
    internal class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            // Here is a bad example of how the calculator should work. As we can see if we need to change the discount condition or add more discount, this class would increase exponentially

            if (budget.Items.Count > 5)
            {
                return budget.Value * 0.1;
            }
            else if (budget.Value > 500)
            {
                return budget.Value * 0.07;
            }

            return 0;
        }
    }
}
