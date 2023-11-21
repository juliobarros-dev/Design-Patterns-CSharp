using Chain_of_Responsability.Models;
using Chain_of_Responsability.Models.Discounts;

namespace Chain_of_Responsability.Services
{
    internal class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            // Now we encapsulated our discount rules but the calculator is not good yet because the 'if problem' still persists.
            // If we want to add more discounts to the system, everytime it happen we would need to readjust the calculator. 

            double desconto = new DiscountPerFiveItems().Discount(budget);

            if (desconto == 0)
            {
                desconto = new DiscountPerMoreThanFiveHundred().Discount(budget);
            }

            return desconto;
        }
    }
}
