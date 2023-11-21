using Chain_of_Responsability.Models;
using Chain_of_Responsability.Models.Discounts;

namespace Chain_of_Responsability.Services
{
    internal class DiscountCalculator
    {
        public double Calculate(Budget budget)
        {
            // Here the calculator is only responsible for organizing the chain and trigger it

            DiscountPerFiveItems discountPerItem = new();
            DiscountPerMoreThanFiveHundred discountPerValue = new();
            NoDiscount noDiscount = new();

            // Here the chain is being created declaring that the next discount must be DiscountPerValue
            discountPerItem.Next = discountPerValue;

            // To prevent exceptions, our calculator needs to determine when to terminate the chain. In this case, if any discount rule is applied, the discount needs to be 0.
            discountPerValue.Next = noDiscount;

            // Here we are requesting to apply the discountPerItems, if the discount is applied it will return the discount value otherwise will call the discountPerValue
            return discountPerItem.Discount(budget);
        }
    }
}
