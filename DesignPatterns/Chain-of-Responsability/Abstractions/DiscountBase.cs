using Chain_of_Responsability.Models;

namespace Chain_of_Responsability.Abstractions
{
    internal abstract class DiscountBase(int discountRate) : IDiscount
    {
        public double DiscountRate { get; set; } = discountRate;
        public IDiscount? Next { get; set; }

        public abstract double Discount(Order order);
    }
}
