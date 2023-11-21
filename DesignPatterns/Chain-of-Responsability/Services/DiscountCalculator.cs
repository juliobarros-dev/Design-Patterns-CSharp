using Chain_of_Responsability.Models;
using Chain_of_Responsability.Models.Discounts;

namespace Chain_of_Responsability.Services
{
    internal class DiscountCalculator
    {
        public static double Calculate(Order budget)
        {
            DiscountPerItemsMoreThan discountPerItemsMoreThan = new(5, 10);
            DiscountPerValueMoreThan discountPerValueMoreThan = new(500, 7);
            DiscountPerItemEqualsTo discountPerItemEqualsTo = new("Pen", 50);

            discountPerItemsMoreThan.Next = discountPerValueMoreThan;
            discountPerValueMoreThan.Next = discountPerItemEqualsTo;

            return discountPerItemsMoreThan.Discount(budget);
        }
    }
}
